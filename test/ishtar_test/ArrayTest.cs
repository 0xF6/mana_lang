namespace ishtar_test
{
    using ishtar;
    using mana.runtime;
    using Xunit;

    public unsafe class ArrayTest : IshtarTestBase
    {
        [Fact]
        public void NewArr()
        {
            using var ctx = CreateContext();
            var arrType = ManaTypeCode.TYPE_I4.AsClass().FullName;

            ctx.EnsureType(arrType);

            var result = ctx.Execute((x, _) =>
            {
                x.Emit(OpCodes.LD_TYPE, arrType);   /* load array elements type */
                x.Emit(OpCodes.LDC_I8_5);           /* load size                */
                x.Emit(OpCodes.NEWARR);             /* create array             */
                x.Emit(OpCodes.RET);                /* return instance of array */
            });


            Assert.Equal(ManaTypeCode.TYPE_ARRAY, result.returnValue->type);
        }
    }
}