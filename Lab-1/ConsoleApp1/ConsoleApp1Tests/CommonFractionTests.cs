using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Tests
{
    [TestClass()]
    public class CommonFractionTests
    {
        [TestMethod()]
        public void TwoOverZeroShouldThrowException()
        {
            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                new CommonFraction(2, 0);
            });
        }

        [TestMethod()]
        public void TwoOver56ShouldEqual1Over28()
        {
            Assert.AreEqual("1/28", new CommonFraction(2, 56).ToString());
        }

        [TestMethod()]
        public void Thirty4OverMinus1ShouldEqualMinus34()
        {
            Assert.AreEqual("-34", new CommonFraction(34, -1).ToString());
        }

        [TestMethod()]
        public void Minus34OverMinus1ShouldEqual34()
        {
            Assert.AreEqual("34", new CommonFraction(-34, -1).ToString());
        }

        [TestMethod()]
        public void Minus34Over1ShouldEqualMinus34()
        {
            Assert.AreEqual("-34", new CommonFraction(-34, 1).ToString());
        }

        [TestMethod()]
        public void ZeroOver1ShouldEqual0()
        {
            Assert.AreEqual("0", new CommonFraction(0, 1).ToString());
        }

        [TestMethod()]
        public void SixOver2ShouldEqual3()
        {
            Assert.AreEqual("3", new CommonFraction(6, 2).ToString());
        }

        [TestMethod()]
        public void Eight5thBy5_12thShouldEqual2_3rd()
        {
            Assert.AreEqual("2/3", (new CommonFraction(8, 5) * new CommonFraction(5, 12)).ToString());
        }

        [TestMethod()]
        public void Minus8_5thByMinus5_12thShouldEqual2_3rd()
        {
            Assert.AreEqual("2/3", (new CommonFraction(-8, 5) * new CommonFraction(-5, 12)).ToString());
        }

        [TestMethod()]
        public void Minus8_5thBy5_12thShouldEqualMinus2_3rd()
        {
            Assert.AreEqual("-2/3", (new CommonFraction(-8, 5) * new CommonFraction(5, 12)).ToString());
        }

        [TestMethod()]
        public void FiveOverZeroShouldThrowException()
        {
            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                CommonFraction f = new CommonFraction(5, 1) / new CommonFraction(0, 1);
            });
        }

        [TestMethod()]
        public void Eight_5thOver12_5thShouldEqual2_3rd()
        {
            Assert.AreEqual("2/3", (new CommonFraction(8, 5) / new CommonFraction(12, 5)).ToString());
        }

        [TestMethod()]
        public void Minus8_5thOverMinus12_5thShouldEqual2_3rd()
        {
            Assert.AreEqual("2/3", (new CommonFraction(8, 5) / new CommonFraction(12, 5)).ToString());
        }

        [TestMethod()]
        public void Minus8_5thOver12_5thShouldEqualMinus2_3rd()
        {
            Assert.AreEqual("-2/3", (new CommonFraction(-8, 5) / new CommonFraction(12, 5)).ToString());
        }

        [TestMethod()]
        public void Eight_5thPlus12_5thShouldEqual4()
        {
            Assert.AreEqual("4", (new CommonFraction(8, 5) + new CommonFraction(12, 5)).ToString());
        }

        [TestMethod()]
        public void Eight_5thMinus12_5thShouldEqualMinus4_5th()
        {
            Assert.AreEqual("-4/5", (new CommonFraction(8, 5) - new CommonFraction(12, 5)).ToString());
        }

        [TestMethod()]
        public void Minus12_5thShouldEqualMinus12_5th()
        {
            Assert.AreEqual("-12/5", (-new CommonFraction(12, 5)).ToString());
        }

        [TestMethod()]
        public void MinusMinus12_5thShouldEqual12_5th()
        {
            Assert.AreEqual("12/5", (-new CommonFraction(-12, 5)).ToString());
        }
    }
}