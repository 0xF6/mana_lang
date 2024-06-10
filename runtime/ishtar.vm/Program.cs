using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using ishtar;
using vein.fs;
using vein.runtime;

unsafe
{
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        Console.OutputEncoding = Encoding.Unicode;

    var vm = VirtualMachine.Create("app");
    var vault = vm.Vault;
    
    var masterModule = default(IshtarAssembly);
    var resolver = default(AssemblyResolver);

    if (AssemblyBundle.IsBundle(out var bundle))
    {
        resolver = vault.GetResolver();
        masterModule = bundle.Assemblies.First();
        resolver.AddInMemory(bundle);
    }
    else
    {
        if (args.Length < 1)
        {
            vm.FastFail(WNE.ASSEMBLY_COULD_NOT_LOAD, "0x1 [module path is not passed]", vm.Frames.EntryPoint);
            return -1;
        }
        var entry = new FileInfo(args.First());
        if (!entry.Exists)
        {
            vm.FastFail(WNE.ASSEMBLY_COULD_NOT_LOAD, $"0x2 [{entry.FullName} is not found]", vm.Frames.EntryPoint);
            return -2;
        }
        vault.WorkDirectory = entry.Directory;
        resolver = vault.GetResolver();
        masterModule = IshtarAssembly.LoadFromFile(entry);
        resolver.AddSearchPath(entry.Directory);
    }


    var module = resolver.Resolve(masterModule);

    module->class_table->ForEach(x => x->init_vtable(x->Owner->vm));
    
    var entry_point = module->GetEntryPoint();

    if (entry_point is null)
    {
        vm.FastFail(WNE.MISSING_METHOD, $"Entry point in '{module->Name}' module is not defined.", vm.Frames.EntryPoint);
        return -280;
    }

    var args_ = stackalloc stackval[1];
    
    var frame = CallFrame.Create(entry_point, null);
    frame->args = args_;


    var watcher = Stopwatch.StartNew();

    entry_point->ForceSetAsAsync();

    vm.task_scheduler->start_threading(module);
    vm.task_scheduler->execute_method(frame);

    if (!frame->exception.IsDefault())
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"unhandled exception '{frame->exception.value->clazz->Name}' was thrown. \n" +
                          $"{frame->exception.GetStackTrace()}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    watcher.Stop();
    Console.WriteLine($"Elapsed: {watcher.Elapsed}");
    frame->Dispose();
    vm.Dispose();

    return 0;
}
