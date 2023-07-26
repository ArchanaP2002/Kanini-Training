using MathOperations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    [TestFixture]

    internal class CalculationTests

    {
        [SetUp]
        public void SetUp() 
        {

        }

        [Test]
        [Order(1)]
        public void AddTest()
        {
            Calculation calculation = new Calculation(100, 100);
            int result = calculation.Add();
            Assert.AreEqual(200, result);
        }
        [Test]
        [Order(2)]
        public void SubTest()
        {
            Calculation calculation = new Calculation(100, 100);
            int result = calculation.Sub();
            Assert.AreEqual(0, result);
        }
        [Test]
        [Order(3)]
        public void MulTest()
        {
            Calculation calculation = new Calculation(100, 100);
            int result = calculation.Sub();
            Assert.AreEqual(0, result);

        }
    }
}
