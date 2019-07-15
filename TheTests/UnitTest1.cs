using System;
using Xunit;
using TheDll;

namespace TheTests
{
    public class UnitTest1
    {
        private TheDll.Class1 _class1;

        // SetupBeforeEachTest
        public UnitTest1()
        {
            _class1 = new TheDll.Class1();
        }

        [Fact]
        public void TrueTest()
        {
            Assert.True(_class1.IsTrue);
        }

        [Fact]
        public void FalseTest()
        {
            Assert.False(_class1.IsFalse);
        }

    }
}
