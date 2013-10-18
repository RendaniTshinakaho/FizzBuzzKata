using NUnit.Framework;

namespace Domain.Test
{
    [TestFixture]
    public class Test
    {
        private IFizzBuzz _fizzBuzz;
        [SetUp]
        public void SetUp()
        {
           _fizzBuzz = new FizzBuzz(); 
        }
         [Test]
         public void OneReturnOne()
         {
             var result = _fizzBuzz.Evaluate(1);
             Assert.That(result,Is.EqualTo("1"));
         }
        [Test]
        public void TwoReturnTwo()
        {
            var result = _fizzBuzz.Evaluate(2);
            Assert.That(result,Is.EqualTo("2"));
        }
        [Test]
        public void ThreeReturnsFizz()
        {
            var result = _fizzBuzz.Evaluate(3);
            Assert.That(result,Is.EqualTo("Fizz"));
        }
        [Test]
        public void FourReturnFour()
        {
            var result = _fizzBuzz.Evaluate(4);
            Assert.That(result,Is.EqualTo("4"));
        }
        [Test]
        public void FiveReturnBuzz()
        {
            var result = _fizzBuzz.Evaluate(5);
            Assert.That(result,Is.EqualTo("Buzz"));
        }
        [Test]
        public void SixthReturnFizz()
        {
            var result = _fizzBuzz.Evaluate(6);
            Assert.That(result,Is.EqualTo("Fizz"));
        }
        [Test]
        public void TenReturnBuzz()
        {
            var result = _fizzBuzz.Evaluate(10);
            Assert.That(result,Is.EqualTo("Buzz"));
        }
        [Test]
        public void FifteenReturnFizzBuzz()
        {
            var result = _fizzBuzz.Evaluate(15);
            Assert.That(result,Is.EqualTo("FizzBuzz"));
        }
    }
}