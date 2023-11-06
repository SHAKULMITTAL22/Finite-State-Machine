using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateBeganEventArgs_FiniteStateChangeEventArgs_08e3fe46ea
    {
        private StateType requestedType;
        private StateInfo stateInfo;

        [SetUp]
        public void Setup()
        {
            requestedType = new StateType();
            stateInfo = new StateInfo();
        }

        [Test]
        public void Constructor_ValidArgs_ConstructedCorrectly()
        {
            var finiteStateChangeEventArgs = new FiniteStateChangeEventArgs(requestedType, stateInfo);

            Assert.AreEqual(requestedType, finiteStateChangeEventArgs.RequestedType);
            Assert.AreEqual(stateInfo, finiteStateChangeEventArgs.StateInfo);
        }

        [Test]
        public void Constructor_NullStateInfo_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => new FiniteStateChangeEventArgs(requestedType, null));
        }

        [Test]
        public void Constructor_NullRequestedType_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => new FiniteStateChangeEventArgs(null, stateInfo));
        }

        [Test]
        public void Constructor_NullRequestedTypeNullStateInfo_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => new FiniteStateChangeEventArgs(null, null));
        }
    }
}
