using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Hand_test_Calculator;

namespace CalculaterNUnit
{
    public class Tests
    {
        private  Calculator uut;
        

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [Test]
        public void Test1()
        {
            
            double plus = uut.Add(2, 8);

            Assert.That(plus, Is.EqualTo(10));
        }
        [Test]
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



        //[TestCase(4,3, ExpectedResult = 12)]
        //public void Test3(double a, double b)
        //{

        //    double gange = uut.Multiply(a, b);


        //}
    }
}