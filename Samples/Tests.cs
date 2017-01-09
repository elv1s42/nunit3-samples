using NUnit.Framework;

namespace Samples
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SuccessTest()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void SuccessTestWithAssert()
        {
            Assert.Pass();
        }
    }
}
