using NUnit.Framework;
using System;

namespace EnterpriseNumberGetter.Tests
{
    public class NumberGetterTests
    {
        [Test]
        public void GivenInput_0_ShouldThrowException()
        {
            var mockInput = new MockInputManager("0");
            var numberGetter = new NumberGetter(mockInput);

            Assert.Throws<Exception>(() => numberGetter.GetNumber());
        }

        [Test]
        public void GivenInput_1_ShouldReturn1()
        {
            var mockInput = new MockInputManager("1");
            var numberGetter = new NumberGetter(mockInput);

            var actual = numberGetter.GetNumber();

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void GivenInput_10_ShouldReturn10()
        {
            var mockInput = new MockInputManager("10");
            var numberGetter = new NumberGetter(mockInput);

            var actual = numberGetter.GetNumber();

            Assert.AreEqual(10, actual);
        }

        [Test]
        public void GivenInput_asdf_ShouldThrowException()
        {
            var mockInput = new MockInputManager("asdf");
            var numberGetter = new NumberGetter(mockInput);

            Assert.Throws<Exception>(() => numberGetter.GetNumber());
        }
    }
}