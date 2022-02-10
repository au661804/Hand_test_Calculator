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

        [TestCase(8, 2, 10)]
        [TestCase(18, 2, 20)]
        [TestCase(32, -4, 28)]
        public void PlusTest(double a, double b, double result)
        {

            result = uut.Add(a, b);

            Assert.That(result, Is.EqualTo(result));
        }

        [TestCase(8, 2, 4)]
        [TestCase(18, 2, 9)]
        [TestCase(32, 4, 8)]
        public void dividereTest(double a, double b, double result)
        {
            double dividere = uut.Divide(a, b);
            Assert.That(dividere, Is.EqualTo(result));
        }


        [TestCase(2, 8, 16)]
        [TestCase(5, 4, 20)]
        [TestCase(9, 8, 72)]
        public void GangeTest(double a, double b, double result)
        {

            double gange = uut.Multiply(a, b);

            Assert.That(gange, Is.EqualTo(result));
        }

        [TestCase(4, 3, 12)]
        public void Test3(double a, double b, double result)
        {

            double gange = uut.Multiply(a, b);




        }



        [Test]
        public void SumTest()
        {
            uut.Multiply(3,6);
            uut.Add(3,7);
            uut.GetSum();

            Assert.That(uut.Accumulator, Is.EqualTo(28));
        }


    }

}