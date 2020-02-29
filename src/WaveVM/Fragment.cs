﻿namespace wave
{
    using System;
    using System.Linq;
    using emit.opcodes;
    using runtime.emit.@unsafe;

    public abstract class Fragment
    {
        private readonly OpCodeValues _code;

        protected Fragment(OpCodeValues code) => _code = code;

        public static implicit operator byte(Fragment f) => (byte)f._code;

        protected abstract string ToTemplateString();

        public static int SizeOf<T>(T t) where T : Fragment
        {
            if (t is IArg)
                return 2;
            if (t is IArgs args)
                return args.Get().Length;
            return 1;
        }
    }

    public abstract class FragmentWithRegisterSlot : Fragment, IArg
    {
        protected readonly byte _register;
        protected readonly byte _slot;

        protected FragmentWithRegisterSlot(string register, string slot, OpCodeValues code) : base(code)
        {
            _register = Storage.GetRegisterByLabel(register);
            _slot = Storage.GetSlotByLabel(slot);
        }

        protected FragmentWithRegisterSlot(byte register, byte slot, OpCodeValues code) : base(code)
        {
            _register = register;
            _slot = slot;
        }

        public byte Get()
            => d8u.Null.Construct(_register, _slot);
    }
}