using NUnit.Framework;

namespace Domain.Test
{
    [TestFixture]
    public class Test
    {
         [Test]
         public void CanCreateClass()
         {
             Assert.That(new FizzBuzz(),Is.Not.Null);
         }
    }
}