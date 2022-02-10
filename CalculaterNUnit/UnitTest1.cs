using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Hand_test_Calculator;

namespace CalculaterNUnit
{
    public class Tests
    {
        private Calculator uut;


        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [Test]
        public void plustest()
        {

            double plus = uut.Add(2, 8);

            Assert.That(plus, Is.EqualTo(10));
        }

        [Test]
        public void dividereTest()
        {
            double dividere = uut.Divide(10, 2);
            Assert.That(dividere, Is.EqualTo(5));
        }

        [Test]
        public void dividereTestmed0()
        {
            double dividere = uut.Divide(0, 2);
            Assert.That(dividere, Is.EqualTo(0));
        }

        public void Test2()
        {

            double gange = uut.Multiply(2, 8);

            Assert.That(gange, Is.EqualTo(16));
        }
        [Test]
        public void Test3()
        {
            double gange = uut.Multiply(2, 8);
            double plus = uut.Add(2, 8);

            double sum = uut.GetSum(gange + plus);

            Assert.That(sum, Is.EqualTo(26));
        }
        [Test]
        public void clearTest()
        {
            double sum = uut.Add(20, 20);
            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }




        //[Test]
        //[TestCase(4,3, ExpectedResult = 12)]
        //public void Test3(double a, double b)
        //{

        //    double gange = uut.Multiply(a, b);


        //}
    }
}