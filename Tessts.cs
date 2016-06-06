using FluentAssertions;
using NUnit.Framework;

namespace resharper_refactor_test
{
    [TestFixture]
    class Tessts
    {
        /// <summary>
        /// Sanity check
        /// </summary>
        [Test]
        public void TestBaseThing()
        {
            var subject = new BaseThing();
            subject.CallMeSometime();
            subject.CallCount.Should().Be(1);
        }
    }
}
