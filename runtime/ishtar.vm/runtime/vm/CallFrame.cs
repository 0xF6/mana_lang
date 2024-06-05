namespace ishtar
{
    using System.Runtime.CompilerServices;
    using System.Text;
    using runtime.gc;
    using runtime;

    public static class CallFrameEx
    {
        public static IshtarGC GetGC(this CallFrame frame) => frame.vm.GC;
    }

    public unsafe class CallFrame(VirtualMachine vm)
    {
        public CallFrame parent;
        public RuntimeIshtarMethod* method;
        public SmartPointer<stackval> returnValue;
        public stackval* args;
        public OpCodeValue last_ip;
        public int level;
        public VirtualMachine vm = vm;

        public CallFrameException exception;


        public void assert(bool conditional, [CallerArgumentExpression("conditional")] string msg = default)
        {
            if (conditional)
                return;
            vm.FastFail(WNE.STATE_CORRUPT, $"Static assert failed: '{msg}'", this);
        }
        public void assert(bool conditional, WNE type, [CallerArgumentExpression("conditional")] string msg = default)
        {
            if (conditional)
                return;
            vm.FastFail(type, $"Static assert failed: '{msg}'", this);
        }


        public void ThrowException(RuntimeIshtarClass* @class) =>
            this.exception = new CallFrameException()
            {
                value = vm.GC.AllocObject(@class, this)
            };

        public void ThrowException(RuntimeIshtarClass* @class, string message)
        {
            this.exception = new CallFrameException()
            {
                value = vm.GC.AllocObject(@class, this)
            };

            if (@class->FindField("message") is null)
                throw new InvalidOperationException($"Class '{@class->FullName->NameWithNS}' is not contained 'message' field.");

            this.exception.value->vtable[@class->Field["message"]->vtable_offset]
                = vm.GC.ToIshtarObject(message, this);
        }

        public string Debug_GetFile()
        {
            // TODO fetch from dbg symbols

            var str = new StringBuilder();

            if (this.method->Owner is not null)
                str.AppendLine($"\tat {this.method->Owner->FullName->NameWithNS}.{this.method->Name}");
            else
                str.AppendLine($"\tat <sys>.{this.method->Name}");

            var r = this.parent;

            while (r != null)
            {
                str.AppendLine($"\tat {r.method->Owner->FullName->NameWithNS}.{r.method->Name}");
                r = r.parent;
            }

            return str.ToString();
        }

        public int Debug_GetLine() => 0;// TODO fetch from dbg symbols

        public static void FillStackTrace(CallFrame frame)
        {
            var str = new StringBuilder();

            if (frame is null)
            {
                Console.WriteLine($"<<DETECTED NULL FRAME>>");
                return;
            }

            if (frame.method != null && !frame.method->IsDisposed() && frame.method->Owner is not null && frame.method->Owner->FullName is not null)
                str.AppendLine($"\tat {frame.method->Owner->FullName->NameWithNS}.{frame.method->Name}");
            else if (frame.method is not null && !frame.method->IsDisposed())
                str.AppendLine($"\tat <sys>.{frame.method->Name}");
            else
                str.AppendLine($"\tat <sys>.ukn+0");


            var r = frame.parent;
            var index = 0;
            while (r != null)
            {
                if (r.method is not null && !r.method->IsDisposed() && r.method->Owner is not null && r.method->Owner->FullName is not null)
                    str.AppendLine($"\tat {r.method->Owner->FullName->NameWithNS}.{r.method->Name}");
                else if (r.method is not null && !r.method->IsDisposed())
                    str.AppendLine($"\tat sys.{r.method->Name}");
                else
                    str.AppendLine($"\tat <sys>.ukn+{++index}");

                r = r.parent;
            }

            frame.exception ??= new CallFrameException();
            frame.exception.stack_trace = str.ToString();
        }
    }
}
