/// <auto-generated> don't touch this file, for modification use gen.csx </auto-generated>
namespace insomnia 
{
	public enum OpCodeValue : ushort 
	{
		/// <summary>
		/// Nope operation.
		/// </summary>
		NOP = 0x00,
		/// <summary>
		/// Add operation.
		/// </summary>
		ADD = 0x01,
		/// <summary>
		/// Substract operation.
		/// </summary>
		SUB = 0x02,
		/// <summary>
		/// Divide operation.
		/// </summary>
		DIV = 0x03,
		/// <summary>
		/// Multiple operation.
		/// </summary>
		MUL = 0x04,
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		LDARG_0 = 0x05,
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		LDARG_1 = 0x06,
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		LDARG_2 = 0x07,
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		LDARG_3 = 0x08,
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		LDARG_4 = 0x09,
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		LDARG_5 = 0x0A,
		/// <summary>
		/// Load into stack from argument.
		/// </summary>
		LDARG_S = 0x0B,
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		LDC_F16 = 0x0C,
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		LDC_F8 = 0x0D,
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		LDC_F4 = 0x0E,
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		LDC_F2 = 0x0F,
		/// <summary>
		/// Load constant into stack.
		/// </summary>
		LDC_STR = 0x10,
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		LDC_I4_0 = 0x11,
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		LDC_I4_1 = 0x12,
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		LDC_I4_2 = 0x13,
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		LDC_I4_3 = 0x14,
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		LDC_I4_4 = 0x15,
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		LDC_I4_5 = 0x16,
		/// <summary>
		/// Load int32 constant into stack.
		/// </summary>
		LDC_I4_S = 0x17,
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		LDC_I2_0 = 0x18,
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		LDC_I2_1 = 0x19,
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		LDC_I2_2 = 0x1A,
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		LDC_I2_3 = 0x1B,
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		LDC_I2_4 = 0x1C,
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		LDC_I2_5 = 0x1D,
		/// <summary>
		/// Load int16 constant into stack.
		/// </summary>
		LDC_I2_S = 0x1E,
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		LDC_I8_0 = 0x1F,
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		LDC_I8_1 = 0x20,
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		LDC_I8_2 = 0x21,
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		LDC_I8_3 = 0x22,
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		LDC_I8_4 = 0x23,
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		LDC_I8_5 = 0x24,
		/// <summary>
		/// Load in64 constant into stack.
		/// </summary>
		LDC_I8_S = 0x25,
		/// <summary>
		/// Debug operation.
		/// </summary>
		DUMP_0 = 0x26,
		/// <summary>
		/// Debug operation.
		/// </summary>
		DUMP_1 = 0x27,
		/// <summary>
		/// Return operation.
		/// </summary>
		RET = 0x28,
		/// <summary>
		/// Call operation.
		/// </summary>
		CALL = 0x29,
		/// <summary>
		/// Load NULL into stack.
		/// </summary>
		LDNULL = 0x2A,
		/// <summary>
		/// Load field into stack.
		/// </summary>
		/// <remarks>
		/// Not used directly.
		/// </remarks>
		LDF = 0x2B,
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		LDLOC_0 = 0x2C,
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		LDLOC_1 = 0x2D,
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		LDLOC_2 = 0x2E,
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		LDLOC_3 = 0x2F,
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		LDLOC_4 = 0x30,
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		LDLOC_5 = 0x31,
		/// <summary>
		/// Load from locals into stack.
		/// </summary>
		LDLOC_S = 0x32,
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		STLOC_0 = 0x33,
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		STLOC_1 = 0x34,
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		STLOC_2 = 0x35,
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		STLOC_3 = 0x36,
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		STLOC_4 = 0x37,
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		STLOC_5 = 0x38,
		/// <summary>
		/// Load from stack into locals.
		/// </summary>
		STLOC_S = 0x39,
		/// <summary>
		/// Initialization locals stack.
		/// </summary>
		LOC_INIT = 0x3A,
		/// <summary>
		/// (part of LOD.INIT) Initialization locals slot as derrived type.
		/// </summary>
		LOC_INIT_X = 0x3B,
		/// <summary>
		/// Duplicate memory from stack.
		/// </summary>
		DUP = 0x3C,
		/// <summary>
		/// XOR Operation.
		/// </summary>
		XOR = 0x3D,
		/// <summary>
		/// OR Operation.
		/// </summary>
		OR = 0x3E,
		/// <summary>
		/// AND Operation.
		/// </summary>
		AND = 0x3F,
		/// <summary>
		/// Shift Right Operation.
		/// </summary>
		SHR = 0x40,
		/// <summary>
		/// Shift Left Operation.
		/// </summary>
		SHL = 0x41,
		/// <summary>
		/// Convertation operation.
		/// </summary>
		CONV_R4 = 0x42,
		/// <summary>
		/// Convertation operation.
		/// </summary>
		CONV_R8 = 0x43,
		/// <summary>
		/// Convertation operation.
		/// </summary>
		CONV_I4 = 0x44,
		/// <summary>
		/// Throw exception operation.
		/// </summary>
		THROW = 0x45,
		/// <summary>
		/// New object Operation.
		/// </summary>
		NEWOBJ = 0x46,
		/// <summary>
		/// Compare two value, when values are equal 1 (int32) stage into stack, otherwise 0 (int32).
		/// </summary>
		EQL = 0x47,
		/// <summary>
		/// Control flow, jump onto label. (unconditional)
		/// </summary>
		JMP = 0x48,
		/// <summary>
		/// Control flow, jump onto label when first value is less than or equal to second value.
		/// </summary>
		JMP_LQ = 0x49,
		/// <summary>
		/// Control flow, jump onto label when first value is less second value.
		/// </summary>
		JMP_L = 0x4A,
		/// <summary>
		/// Control flow, jump onto label when first value is greater than or equal to second value.
		/// </summary>
		JMP_HQ = 0x4B,
		/// <summary>
		/// Control flow, jump onto label when first value is greater second value.
		/// </summary>
		JMP_H = 0x4C,
		/// <summary>
		/// Control flow, jump onto label when two integer/float is equal.
		/// </summary>
		JMP_NQ = 0x4D,
		/// <summary>
		/// Control flow, jump onto label when two integer/float is not equal.
		/// </summary>
		JMP_NN = 0x4E,
		/// <summary>
		/// Control flow, jump onto label when value has false, null or zero.
		/// </summary>
		JMP_F = 0x4F,
		/// <summary>
		/// Control flow, jump onto label when value has true or either differs from null or from zero.
		/// </summary>
		JMP_T = 0x50,
	}
}
