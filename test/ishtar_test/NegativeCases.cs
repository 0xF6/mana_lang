﻿namespace ishtar_test
{
    using ishtar;
    using Xunit;
    using Xunit.Sdk;

    public class NegativeCases : IshtarTestBase
    {
        [Fact(Skip = "floating state test, fix it")]
        public unsafe void IncorrectPointerCrashTest()
        {
            Assert.Throws<FalseException>(() =>
            {
                var invalid = new StrRef {index = 534534};
                return StrRef.Unwrap(&invalid);
            });
        }


        protected override void StartUp() { }
        protected override void Shutdown() { }
    }
}