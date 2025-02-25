using NUnit.Framework;
using ExceptionHandling;
namespace ExceptionHandlingTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Divide_GivenZeroAsDivisor_ThrowsArithmeticException()
        {
            Assert.Throws<DivideByZeroException>(() => Operarion.Divide(10, 0));
        }

    }
}
