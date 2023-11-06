using System;
using NUnit.Framework;

namespace FiniteStateMachine.Test
{
    public class StateMachineTests
    {
        private StateMachine<int> _stateMachine;

        [SetUp]
        public void Setup()
        {
            _stateMachine = new StateMachine<int>();
        }

        [Test]
        public void TestThatStateCreatesCorrectState()
        {
            var state = new State<int>(_stateMachine, 1);
            Assert.AreEqual(_stateMachine, state.StateMachine);
        }

        [Test]
        public void TestThatStateAssignsCorrectKey()
        {
            var state = new State<int>(_stateMachine, 1);
            Assert.AreEqual(1, state.StateKey);
        }

        [Test]
        public void TestThatNullStateMachineThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => new State<int>(null, 1));
        }
    }
}
