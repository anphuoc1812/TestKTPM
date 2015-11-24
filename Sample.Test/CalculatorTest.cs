using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace Sample.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private Class1 _cal;

        [SetUp]
        public void SetUp()
        {
            _cal = new Class1();
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 6, 8)]
        [TestCase(-1, 9, 8)]
        public void TestCong(int a, int b, int kq)
        {
            Assert.AreEqual(kq, _cal.Cong(a, b));
        }

        [TestCase(0, 3, 0)]
        [TestCase(3, 0, 0)]
        [TestCase(-1, 5, -5)]
        [TestCase(5, -5, -25)]
        [TestCase(4, 2, 8)]
        public void TestNhan(int a, int b, int kq)
        {
            Assert.AreEqual(kq, _cal.Nhan(a, b));
        }
    }
}
