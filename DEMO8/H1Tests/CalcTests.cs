using Microsoft.VisualStudio.TestTools.UnitTesting;
using H1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calc calc = new Calc();
            int number1 = 5;
            int number2 = 7;
            int expected = 12;

            //act
            int actual = calc.Add(number1, number2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultipleTest()
        {
            Calc calc = new Calc();
            int number1 = 5;
            int number2 = 7;
            int expected = 35;

            //act
            int actual = calc.Multiple(number1, number2);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}