using Leticia;
using System;
using Xunit;

namespace cristina
{
    public class UnitTest1
    {
        [Fact]
        public void TestPositivo()
        {
            Class_operator service = new Class_operator();

            int character = service.result("a || b = x");
            Assert.Equal(1, character);

        }

        [Fact]
        public void TestNegativo()
        {
            Class_operator service = new Class_operator();

            int character = service.result("a || b = x");
            Assert.Equal(3, character);

        }
    }
}
