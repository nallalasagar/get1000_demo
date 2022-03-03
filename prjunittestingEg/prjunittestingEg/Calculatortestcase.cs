using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjunittestingEg
{
    class Calculatortestcase
    {
        calculator calculator = new calculator();


        [TestCase]

        public void Add()
        {
            Assert.AreEqual(40, calculator.Addition(30, 10));
        }
        [TestCase]

        public void sub()
        {
            Assert.Catch<ArgumentException>(()=>calculator.Subtraction(2,4));
        }


        [TestCase]

        public void Add()
        {
            Assert.Positive
        }

    }
}
