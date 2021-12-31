/// <auto-generated> don't touch this file, for modification use gen.csx </auto-generated>
namespace ishtar 
{
	using global::vein.runtime;
	using global::ishtar.emit;
	using global::System.Collections.Generic;
	public static class OpCodes 
	{
		internal static int SetVersion = 18;
		/// <summary>
		/// Nope operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode NOP = new (0x00, 0x0000001F);
		/// <summary>
		/// Add operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode ADD = new (0x01, 0x0000001F);
		/// <summary>
		/// Substract operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SUB = new (0x02, 0x0000001F);
		/// <summary>
		/// Divide operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode DIV = new (0x03, 0x0000001F);
		/// <summary>
		/// Multiple operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode MUL = new (0x04, 0x0000001F);
		/// <summary>
		/// Modulo operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode MOD = new (0x05, 0x0000001F);
		/// <summary>
		/// Load into stack from argument.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDARG_0 = new (0x06, 0x0000001F);
		/// <summary>
		/// Load into stack from argument.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDARG_1 = new (0x07, 0x0000001F);
		/// <summary>
		/// Load into stack from argument.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDARG_2 = new (0x08, 0x0000001F);
		/// <summary>
		/// Load into stack from argument.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDARG_3 = new (0x09, 0x0000001F);
		/// <summary>
		/// Load into stack from argument.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDARG_4 = new (0x0A, 0x0000001F);
		/// <summary>
		/// Load into stack from argument.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDARG_5 = new (0x0B, 0x0000001F);
		/// <summary>
		/// Load into stack from argument by index.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDARG_S = new (0x0C, 0x0100001F);
		/// <summary>
		/// Stage into argument from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STARG_0 = new (0x0D, 0x0000001F);
		/// <summary>
		/// Stage into argument from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STARG_1 = new (0x0E, 0x0000001F);
		/// <summary>
		/// Stage into argument from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STARG_2 = new (0x0F, 0x0000001F);
		/// <summary>
		/// Stage into argument from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STARG_3 = new (0x10, 0x0000001F);
		/// <summary>
		/// Stage into argument from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STARG_4 = new (0x11, 0x0000001F);
		/// <summary>
		/// Stage into argument from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STARG_5 = new (0x12, 0x0000001F);
		/// <summary>
		/// Stage into argument from stack by index.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STARG_S = new (0x13, 0x0100001F);
		/// <summary>
		/// Load constant into stack.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_F4 = new (0x14, 0x0100001F);
		/// <summary>
		/// Load constant into stack.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_F2 = new (0x15, 0x0100001F);
		/// <summary>
		/// Load constant into stack.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_STR = new (0x16, 0x0100001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I4_0 = new (0x17, 0x0000001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I4_1 = new (0x18, 0x0000001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I4_2 = new (0x19, 0x0000001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I4_3 = new (0x1A, 0x0000001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I4_4 = new (0x1B, 0x0000001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I4_5 = new (0x1C, 0x0000001F);
		/// <summary>
		/// Load int32 constant into stack.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I4_S = new (0x1D, 0x0100001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I2_0 = new (0x1E, 0x0000001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I2_1 = new (0x1F, 0x0000001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I2_2 = new (0x20, 0x0000001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I2_3 = new (0x21, 0x0000001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I2_4 = new (0x22, 0x0000001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I2_5 = new (0x23, 0x0000001F);
		/// <summary>
		/// Load int16 constant into stack.
		/// size: 2
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I2_S = new (0x24, 0x0080001F);
		/// <summary>
		/// Load int64 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I8_0 = new (0x25, 0x0000001F);
		/// <summary>
		/// Load int64 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I8_1 = new (0x26, 0x0000001F);
		/// <summary>
		/// Load int64 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I8_2 = new (0x27, 0x0000001F);
		/// <summary>
		/// Load int64 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I8_3 = new (0x28, 0x0000001F);
		/// <summary>
		/// Load int64 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I8_4 = new (0x29, 0x0000001F);
		/// <summary>
		/// Load int64 constant into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I8_5 = new (0x2A, 0x0000001F);
		/// <summary>
		/// Load int64 constant into stack.
		/// size: 8
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_I8_S = new (0x2B, 0x0200001F);
		/// <summary>
		/// Load float64 constant into stack.
		/// size: 8
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_F8 = new (0x2C, 0x0200001F);
		/// <summary>
		/// Load float128 constant into stack.
		/// size: 20
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDC_F16 = new (0x2D, 0x0500001F);
		/// <summary>
		/// Reserved operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode RESERVED_0 = new (0x2E, 0x0000001F);
		/// <summary>
		/// Reserved operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode RESERVED_1 = new (0x2F, 0x0000001F);
		/// <summary>
		/// Reserved operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode RESERVED_2 = new (0x30, 0x0000001F);
		/// <summary>
		/// Return operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode RET = new (0x31, 0x0000001F);
		/// <summary>
		/// Call operation.
		/// size: 8
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode CALL = new (0x32, 0x0200001F);
		/// <summary>
		/// Load NULL into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDNULL = new (0x33, 0x0000001F);
		/// <summary>
		/// Load value from field in instance into stack.
		/// size: 8
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDF = new (0x34, 0x0200001F);
		/// <summary>
		/// Load value from static field into stack.
		/// size: 8
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDSF = new (0x35, 0x0200001F);
		/// <summary>
		/// Stage into instance field value from stack.
		/// size: 8
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STF = new (0x36, 0x0200001F);
		/// <summary>
		/// Stage into static field value from stack.
		/// size: 8
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STSF = new (0x37, 0x0200001F);
		/// <summary>
		/// Load from locals into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLOC_0 = new (0x38, 0x0000001F);
		/// <summary>
		/// Load from locals into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLOC_1 = new (0x39, 0x0000001F);
		/// <summary>
		/// Load from locals into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLOC_2 = new (0x3A, 0x0000001F);
		/// <summary>
		/// Load from locals into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLOC_3 = new (0x3B, 0x0000001F);
		/// <summary>
		/// Load from locals into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLOC_4 = new (0x3C, 0x0000001F);
		/// <summary>
		/// Load from locals into stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLOC_5 = new (0x3D, 0x0000001F);
		/// <summary>
		/// 
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLOC_S = new (0x3E, 0x0100001F);
		/// <summary>
		/// Load from stack into locals.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STLOC_0 = new (0x3F, 0x0000001F);
		/// <summary>
		/// Load from stack into locals.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STLOC_1 = new (0x40, 0x0000001F);
		/// <summary>
		/// Load from stack into locals.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STLOC_2 = new (0x41, 0x0000001F);
		/// <summary>
		/// Load from stack into locals.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STLOC_3 = new (0x42, 0x0000001F);
		/// <summary>
		/// Load from stack into locals.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STLOC_4 = new (0x43, 0x0000001F);
		/// <summary>
		/// Load from stack into locals.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STLOC_5 = new (0x44, 0x0000001F);
		/// <summary>
		/// 
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STLOC_S = new (0x45, 0x0100001F);
		/// <summary>
		/// Initialization locals stack.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LOC_INIT = new (0x46, 0x0100001F);
		/// <summary>
		/// (part of LOD.INIT) Initialization locals slot as derrived type.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LOC_INIT_X = new (0x47, 0x0100001F);
		/// <summary>
		/// Duplicate memory from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode DUP = new (0x48, 0x0000001F);
		/// <summary>
		/// Pop value from stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode POP = new (0x69, 0x0000001F);
		/// <summary>
		/// Allocate memory block.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode ALLOC_BLOCK = new (0x6A, 0x0100001F);
		/// <summary>
		/// Leave from protected zone.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SEH_LEAVE_S = new (0x6C, 0x0100001F);
		/// <summary>
		/// Leave from protected zone.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SEH_LEAVE = new (0x6D, 0x0000001F);
		/// <summary>
		/// End of finally statement.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SEH_FINALLY = new (0x6E, 0x0000001F);
		/// <summary>
		/// End of filter statement.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SEH_FILTER = new (0x6F, 0x0000001F);
		/// <summary>
		/// Enter protected zone.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SEH_ENTER = new (0x70, 0x0100001F);
		/// <summary>
		/// Free memory at point in stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode DELETE = new (0x6B, 0x0000001F);
		/// <summary>
		/// XOR Operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode XOR = new (0x49, 0x0000001F);
		/// <summary>
		/// OR Operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode OR = new (0x4A, 0x0000001F);
		/// <summary>
		/// AND Operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode AND = new (0x4B, 0x0000001F);
		/// <summary>
		/// Shift Right Operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SHR = new (0x4C, 0x0000001F);
		/// <summary>
		/// Shift Left Operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode SHL = new (0x4D, 0x0000001F);
		/// <summary>
		/// Convertation operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode CONV_R4 = new (0x4E, 0x0000001F);
		/// <summary>
		/// Convertation operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode CONV_R8 = new (0x4F, 0x0000001F);
		/// <summary>
		/// Convertation operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode CONV_I4 = new (0x50, 0x0000001F);
		/// <summary>
		/// Throw exception operation.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode THROW = new (0x51, 0x0000001F);
		/// <summary>
		/// New object Operation.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode NEWOBJ = new (0x52, 0x0100001F);
		/// <summary>
		/// Cast T1 to T2
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode CAST = new (0x71, 0x0000001F);
		/// <summary>
		/// Allocate array onto evaluation stack by specified size and type.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode NEWARR = new (0x53, 0x0000001F);
		/// <summary>
		/// Load size of Array onto evaluation stack.
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDLEN = new (0x54, 0x0000001F);
		/// <summary>
		/// 
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LDELEM_S = new (0x55, 0x0100001F);
		/// <summary>
		/// 
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode STELEM_S = new (0x56, 0x0100001F);
		/// <summary>
		/// Load type token.
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode LD_TYPE = new (0x57, 0x0100001F);
		/// <summary>
		/// Compare two value, when first value is less than or equal to second value stage 1 (int32) into stack, otherwise 0 (int32). (a <= b)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_LQ = new (0x58, 0x0000001F);
		/// <summary>
		/// Compare two value, when first value is less second value stage 1 (int32) into stack, otherwise 0 (int32). (a < b)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_L = new (0x59, 0x0000001F);
		/// <summary>
		/// Compare two value, when first value is greater than or equal to second value stage 1 (int32) into stack, otherwise 0 (int32). (a >= b)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_HQ = new (0x5A, 0x0000001F);
		/// <summary>
		/// Compare two value, when first value is greater second value stage 1 (int32) into stack, otherwise 0 (int32). (a > b)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_H = new (0x5B, 0x0000001F);
		/// <summary>
		/// Compare two value, when two integer/float is equal stage 1 (int32) into stack, otherwise 0 (int32). (a == b)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_NQ = new (0x5C, 0x0000001F);
		/// <summary>
		/// Compare two value, when two integer/float is not equal stage 1 (int32) into stack, otherwise 0 (int32). (a != b)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_NN = new (0x5D, 0x0000001F);
		/// <summary>
		/// Compare two value, when value has false, null or zero stage 1 (int32) into stack, otherwise 0 (int32). (!a)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_F = new (0x5E, 0x0000001F);
		/// <summary>
		/// Compare two value, when value has true or either differs from null or from zero stage 1 (int32) into stack, otherwise 0 (int32). (a)
		/// size: 0
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode EQL_T = new (0x5F, 0x0000001F);
		/// <summary>
		/// Control flow, jump onto label. (unconditional)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP = new (0x60, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when first value is less than or equal to second value. (a <= b)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_LQ = new (0x61, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when first value is less second value. (a < b)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_L = new (0x62, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when first value is greater than or equal to second value. (a >= b)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_HQ = new (0x63, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when first value is greater second value. (a > b)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_H = new (0x64, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when two integer/float is equal. (a == b)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_NQ = new (0x65, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when two integer/float is not equal. (a != b)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_NN = new (0x66, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when value has false, null or zero. (!a)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_F = new (0x67, 0x0100001F);
		/// <summary>
		/// Control flow, jump onto label when value has true or either differs from null or from zero. (a)
		/// size: 4
		/// flow: 0
		/// chain: 0
		/// </summary>
		public static readonly OpCode JMP_T = new (0x68, 0x0100001F);

		public static readonly Dictionary<OpCodeValue, OpCode> all = new ()
		{
			{OpCodeValue.NOP, NOP},
			{OpCodeValue.ADD, ADD},
			{OpCodeValue.SUB, SUB},
			{OpCodeValue.DIV, DIV},
			{OpCodeValue.MUL, MUL},
			{OpCodeValue.MOD, MOD},
			{OpCodeValue.LDARG_0, LDARG_0},
			{OpCodeValue.LDARG_1, LDARG_1},
			{OpCodeValue.LDARG_2, LDARG_2},
			{OpCodeValue.LDARG_3, LDARG_3},
			{OpCodeValue.LDARG_4, LDARG_4},
			{OpCodeValue.LDARG_5, LDARG_5},
			{OpCodeValue.LDARG_S, LDARG_S},
			{OpCodeValue.STARG_0, STARG_0},
			{OpCodeValue.STARG_1, STARG_1},
			{OpCodeValue.STARG_2, STARG_2},
			{OpCodeValue.STARG_3, STARG_3},
			{OpCodeValue.STARG_4, STARG_4},
			{OpCodeValue.STARG_5, STARG_5},
			{OpCodeValue.STARG_S, STARG_S},
			{OpCodeValue.LDC_F4, LDC_F4},
			{OpCodeValue.LDC_F2, LDC_F2},
			{OpCodeValue.LDC_STR, LDC_STR},
			{OpCodeValue.LDC_I4_0, LDC_I4_0},
			{OpCodeValue.LDC_I4_1, LDC_I4_1},
			{OpCodeValue.LDC_I4_2, LDC_I4_2},
			{OpCodeValue.LDC_I4_3, LDC_I4_3},
			{OpCodeValue.LDC_I4_4, LDC_I4_4},
			{OpCodeValue.LDC_I4_5, LDC_I4_5},
			{OpCodeValue.LDC_I4_S, LDC_I4_S},
			{OpCodeValue.LDC_I2_0, LDC_I2_0},
			{OpCodeValue.LDC_I2_1, LDC_I2_1},
			{OpCodeValue.LDC_I2_2, LDC_I2_2},
			{OpCodeValue.LDC_I2_3, LDC_I2_3},
			{OpCodeValue.LDC_I2_4, LDC_I2_4},
			{OpCodeValue.LDC_I2_5, LDC_I2_5},
			{OpCodeValue.LDC_I2_S, LDC_I2_S},
			{OpCodeValue.LDC_I8_0, LDC_I8_0},
			{OpCodeValue.LDC_I8_1, LDC_I8_1},
			{OpCodeValue.LDC_I8_2, LDC_I8_2},
			{OpCodeValue.LDC_I8_3, LDC_I8_3},
			{OpCodeValue.LDC_I8_4, LDC_I8_4},
			{OpCodeValue.LDC_I8_5, LDC_I8_5},
			{OpCodeValue.LDC_I8_S, LDC_I8_S},
			{OpCodeValue.LDC_F8, LDC_F8},
			{OpCodeValue.LDC_F16, LDC_F16},
			{OpCodeValue.RESERVED_0, RESERVED_0},
			{OpCodeValue.RESERVED_1, RESERVED_1},
			{OpCodeValue.RESERVED_2, RESERVED_2},
			{OpCodeValue.RET, RET},
			{OpCodeValue.CALL, CALL},
			{OpCodeValue.LDNULL, LDNULL},
			{OpCodeValue.LDF, LDF},
			{OpCodeValue.LDSF, LDSF},
			{OpCodeValue.STF, STF},
			{OpCodeValue.STSF, STSF},
			{OpCodeValue.LDLOC_0, LDLOC_0},
			{OpCodeValue.LDLOC_1, LDLOC_1},
			{OpCodeValue.LDLOC_2, LDLOC_2},
			{OpCodeValue.LDLOC_3, LDLOC_3},
			{OpCodeValue.LDLOC_4, LDLOC_4},
			{OpCodeValue.LDLOC_5, LDLOC_5},
			{OpCodeValue.LDLOC_S, LDLOC_S},
			{OpCodeValue.STLOC_0, STLOC_0},
			{OpCodeValue.STLOC_1, STLOC_1},
			{OpCodeValue.STLOC_2, STLOC_2},
			{OpCodeValue.STLOC_3, STLOC_3},
			{OpCodeValue.STLOC_4, STLOC_4},
			{OpCodeValue.STLOC_5, STLOC_5},
			{OpCodeValue.STLOC_S, STLOC_S},
			{OpCodeValue.LOC_INIT, LOC_INIT},
			{OpCodeValue.LOC_INIT_X, LOC_INIT_X},
			{OpCodeValue.DUP, DUP},
			{OpCodeValue.POP, POP},
			{OpCodeValue.ALLOC_BLOCK, ALLOC_BLOCK},
			{OpCodeValue.SEH_LEAVE_S, SEH_LEAVE_S},
			{OpCodeValue.SEH_LEAVE, SEH_LEAVE},
			{OpCodeValue.SEH_FINALLY, SEH_FINALLY},
			{OpCodeValue.SEH_FILTER, SEH_FILTER},
			{OpCodeValue.SEH_ENTER, SEH_ENTER},
			{OpCodeValue.DELETE, DELETE},
			{OpCodeValue.XOR, XOR},
			{OpCodeValue.OR, OR},
			{OpCodeValue.AND, AND},
			{OpCodeValue.SHR, SHR},
			{OpCodeValue.SHL, SHL},
			{OpCodeValue.CONV_R4, CONV_R4},
			{OpCodeValue.CONV_R8, CONV_R8},
			{OpCodeValue.CONV_I4, CONV_I4},
			{OpCodeValue.THROW, THROW},
			{OpCodeValue.NEWOBJ, NEWOBJ},
			{OpCodeValue.CAST, CAST},
			{OpCodeValue.NEWARR, NEWARR},
			{OpCodeValue.LDLEN, LDLEN},
			{OpCodeValue.LDELEM_S, LDELEM_S},
			{OpCodeValue.STELEM_S, STELEM_S},
			{OpCodeValue.LD_TYPE, LD_TYPE},
			{OpCodeValue.EQL_LQ, EQL_LQ},
			{OpCodeValue.EQL_L, EQL_L},
			{OpCodeValue.EQL_HQ, EQL_HQ},
			{OpCodeValue.EQL_H, EQL_H},
			{OpCodeValue.EQL_NQ, EQL_NQ},
			{OpCodeValue.EQL_NN, EQL_NN},
			{OpCodeValue.EQL_F, EQL_F},
			{OpCodeValue.EQL_T, EQL_T},
			{OpCodeValue.JMP, JMP},
			{OpCodeValue.JMP_LQ, JMP_LQ},
			{OpCodeValue.JMP_L, JMP_L},
			{OpCodeValue.JMP_HQ, JMP_HQ},
			{OpCodeValue.JMP_H, JMP_H},
			{OpCodeValue.JMP_NQ, JMP_NQ},
			{OpCodeValue.JMP_NN, JMP_NN},
			{OpCodeValue.JMP_F, JMP_F},
			{OpCodeValue.JMP_T, JMP_T},
		};
	}
}
