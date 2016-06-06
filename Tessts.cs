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

        [Test]
        public void TestMiddleThing()
        {
            var subject = new MiddleClass();

            // resharper also incorrectly removes this usage:

            subject.CallCount.Should().Be(1);
        }

        [Test]
        public void TestUpperThing()
        {
            var subject = new UpperClass();
            subject.CallMeSometime();
            subject.CallCount.Should().Be(1);
        }
    }
}
