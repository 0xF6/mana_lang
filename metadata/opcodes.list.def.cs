/// <auto-generated> don't touch this file, for modification use gen.csx </auto-generated>
namespace wave 
{
	using global::wave.runtime.emit;
	public static class OpCodes 
	{
		/// <summary>
		/// Nope operation.
		/// </summary>
		public static OpCode NOP = new (0x00, 0x00001F);
		/// <summary>
		/// Add operation.
		/// </summary>
		public static OpCode ADD = new (0x01, 0x00001F);
		/// <summary>
		/// Substract operation.
		/// </summary>
		public static OpCode SUB = new (0x02, 0x00001F);
		/// <summary>
		/// Divide operation.
		/// </summary>
		public static OpCode DIV = new (0x03, 0x00001F);
		/// <summary>
		/// Multiple operation.
		/// </summary>
		public static OpCode MUL = new (0x04, 0x00001F);
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		public static OpCode LDARG_0 = new (0x05, 0x00001F);
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		public static OpCode LDARG_1 = new (0x06, 0x00001F);
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		public static OpCode LDARG_2 = new (0x07, 0x00001F);
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		public static OpCode LDARG_3 = new (0x08, 0x00001F);
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		public static OpCode LDARG_4 = new (0x09, 0x00001F);
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		public static OpCode LDARG_5 = new (0x0A, 0x00001F);
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		public static OpCode LDARG_S = new (0x0B, 0x40001F);
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		public static OpCode LDC_F16 = new (0x0C, 0x00001F);
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		public static OpCode LDC_F8 = new (0x0D, 0x00001F);
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		public static OpCode LDC_F4 = new (0x0E, 0x00001F);
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		public static OpCode LDC_F2 = new (0x0F, 0x00001F);
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		public static OpCode LDC_STR = new (0x10, 0x00001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		public static OpCode LDC_I4_0 = new (0x11, 0x00001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		public static OpCode LDC_I4_1 = new (0x12, 0x00001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		public static OpCode LDC_I4_2 = new (0x13, 0x00001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		public static OpCode LDC_I4_3 = new (0x14, 0x00001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		public static OpCode LDC_I4_4 = new (0x15, 0x00001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		public static OpCode LDC_I4_5 = new (0x16, 0x00001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		public static OpCode LDC_I4_S = new (0x17, 0x40001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		public static OpCode LDC_I2_0 = new (0x18, 0x00001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		public static OpCode LDC_I2_1 = new (0x19, 0x00001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		public static OpCode LDC_I2_2 = new (0x1A, 0x00001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		public static OpCode LDC_I2_3 = new (0x1B, 0x00001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		public static OpCode LDC_I2_4 = new (0x1C, 0x00001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		public static OpCode LDC_I2_5 = new (0x1D, 0x00001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		public static OpCode LDC_I2_S = new (0x1E, 0x40001F);
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		public static OpCode LDC_I8_0 = new (0x1F, 0x00001F);
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		public static OpCode LDC_I8_1 = new (0x20, 0x00001F);
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		public static OpCode LDC_I8_2 = new (0x21, 0x00001F);
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		public static OpCode LDC_I8_3 = new (0x22, 0x00001F);
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		public static OpCode LDC_I8_4 = new (0x23, 0x00001F);
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		public static OpCode LDC_I8_5 = new (0x24, 0x00001F);
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		public static OpCode LDC_I8_S = new (0x25, 0x80001F);
		/// <summary>
		/// Debug operation.
		/// </summary>
		public static OpCode DUMP_0 = new (0x26, 0x00001F);
		/// <summary>
		/// Debug operation.
		/// </summary>
		public static OpCode DUMP_1 = new (0x27, 0x00001F);
		/// <summary>
		/// Return operation.
		/// </summary>
		public static OpCode RET = new (0x28, 0x00001F);
		/// <summary>
		/// Call operation.
		/// </summary>
		public static OpCode CALL = new (0x29, 0x80001F);
		/// <summary>
		/// Load NULL into stack.
		/// </summary>
		public static OpCode LDNULL = new (0x2A, 0x00001F);
		/// <summary>
		/// Load field into stack.
		/// </summary>
		/// <remarks>
		/// Not used directly.
		/// </remarks>
		public static OpCode LDF = new (0x2B, 0x00001F);
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		public static OpCode LDLOC_0 = new (0x2C, 0x00001F);
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		public static OpCode LDLOC_1 = new (0x2D, 0x00001F);
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		public static OpCode LDLOC_2 = new (0x2E, 0x00001F);
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		public static OpCode LDLOC_3 = new (0x2F, 0x00001F);
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		public static OpCode LDLOC_4 = new (0x30, 0x00001F);
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		public static OpCode LDLOC_5 = new (0x31, 0x00001F);
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		public static OpCode LDLOC_S = new (0x32, 0x40001F);
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		public static OpCode STLOC_0 = new (0x33, 0x00001F);
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		public static OpCode STLOC_1 = new (0x34, 0x00001F);
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		public static OpCode STLOC_2 = new (0x35, 0x00001F);
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		public static OpCode STLOC_3 = new (0x36, 0x00001F);
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		public static OpCode STLOC_4 = new (0x37, 0x00001F);
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		public static OpCode STLOC_5 = new (0x38, 0x00001F);
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		public static OpCode STLOC_S = new (0x39, 0x40001F);
		/// <summary>
		/// Initialization locals stack  .
		/// </summary>
		public static OpCode LOC_INIT = new (0x3A, 0x40001F);
		/// <summary>
		/// Duplicate memory from stack.
		/// </summary>
		public static OpCode DUP = new (0x3B, 0x00001F);
		/// <summary>
		/// XOR Operation.
		/// </summary>
		public static OpCode XOR = new (0x3C, 0x00001F);
		/// <summary>
		/// AND Operation.
		/// </summary>
		public static OpCode AND = new (0x3D, 0x00001F);
		/// <summary>
		/// Shift Right Operation.
		/// </summary>
		public static OpCode SHR = new (0x3E, 0x00001F);
		/// <summary>
		/// Shift Left Operation.
		/// </summary>
		public static OpCode SHL = new (0x3F, 0x00001F);
		/// <summary>
		/// Convertation operation.
		/// </summary>
		public static OpCode CONV_R4 = new (0x40, 0x00001F);
		/// <summary>
		/// Convertation operation.
		/// </summary>
		public static OpCode CONV_R8 = new (0x41, 0x00001F);
		/// <summary>
		/// Convertation operation.
		/// </summary>
		public static OpCode CONV_I4 = new (0x42, 0x00001F);
		/// <summary>
		/// Throw exception operation.
		/// </summary>
		public static OpCode THROW = new (0x43, 0x00001F);
		/// <summary>
		/// New object Operation.
		/// </summary>
		public static OpCode NEWOBJ = new (0x44, 0x80001F);
		/// <summary>
		/// Control flow, jump onto label. (unconditional)
		/// </summary>
		public static OpCode JMP = new (0x45, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when first value is less than or equal to second value.
		/// </summary>
		public static OpCode JMP_LQ = new (0x46, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when first value is less second value.
		/// </summary>
		public static OpCode JMP_L = new (0x47, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when first value is greater than or equal to second value.
		/// </summary>
		public static OpCode JMP_HQ = new (0x48, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when first value is greater second value.
		/// </summary>
		public static OpCode JMP_H = new (0x49, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when two integer/float is equal.
		/// </summary>
		public static OpCode JMP_NQ = new (0x4A, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when two integer/float is not equal.
		/// </summary>
		public static OpCode JMP_NN = new (0x4B, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when value has false, null or zero.
		/// </summary>
		public static OpCode JMP_F = new (0x4C, 0x40001F);
		/// <summary>
		/// Control flow, jump onto label when value has true or either differs from null or from zero.
		/// </summary>
		public static OpCode JMP_T = new (0x4D, 0x40001F);
	}
}
