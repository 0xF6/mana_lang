﻿namespace wave.emit
{
    using static MethodFlags;
    using static WaveTypeCode;

    public static class BuiltinGen
    {
        public static WaveType GenerateConsole(ModuleBuilder module)
        {
            var clazz = module.DefineClass("global::wave/lang/console");

            clazz.DefineMethod("println", Extern | Static | Public, 
                TYPE_VOID.AsType(),
                ("value", TYPE_STRING));
            clazz.DefineMethod("print", Extern | Static | Public,
                TYPE_VOID.AsType(),
                ("value", TYPE_STRING));

            return clazz.AsType();
        }
    }
    
    
    public static class ClassBuilderExtension
    {
        public static WaveType AsType(this ClassBuilder builder) 
            => new WaveTypeImpl(builder.GetName(), TYPE_CLASS, builder.GetFlags());
    }
}