using EnterpriseNumberGetter.Core;
using NSubstitute;
using NUnit.Framework;
using System;

namespace EnterpriseNumberGetter.Tests
{
    public class NumberGetterTests
    {
        private IDisplayManager _displayManager;
        private IInputManager _inputManager;

        [SetUp]
        public void Init()
        {
            _displayManager = Substitute.For<IDisplayManager>();
            _inputManager = Substitute.For<IInputManager>();
        }


        [Test]
        public void GivenInput_0_ShouldThrowException()
        {
            _inputManager.GetInput().Returns("0");
            var numberGetter = new NumberGetter(_inputManager, _displayManager);

            Assert.Throws<ArgumentOutOfRangeException>(() => numberGetter.GetNumber());
        }

        [Test]
        public void GivenInput_1_ShouldReturn1()
        {
            _inputManager.GetInput().Returns("1");
            var numberGetter = new NumberGetter(_inputManager, _displayManager);

            var actual = numberGetter.GetNumber();

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void GivenInput_10_ShouldReturn10()
        {
            _inputManager.GetInput().Returns("10");
            var numberGetter = new NumberGetter(_inputManager, _displayManager);

            var actual = numberGetter.GetNumber();

            Assert.AreEqual(10, actual);
        }

        [Test]
        public void GivenInput_asdf_ShouldThrowException()
        {
            _inputManager.GetInput().Returns("asdf");
            var numberGetter = new NumberGetter(_inputManager, _displayManager);

            Assert.Throws<ArgumentException>(() => numberGetter.GetNumber());
        }
    }
}