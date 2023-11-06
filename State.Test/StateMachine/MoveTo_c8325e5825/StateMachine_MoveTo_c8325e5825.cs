using NUnit.Framework;
using FiniteStateMachine;
using System;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachineTest
    {
        private FiniteStateMachine<string> fsm;
        private Dictionary<string, State<string>> m_states;

        [SetUp]
        public void SetUp()
        {
            m_states = new Dictionary<string, State<string>>()
            {
                { "state1", new State<string>("state1") },
                { "state2", new State<string>("state2") }
            };
            fsm = new FiniteStateMachine<string>(m_states);
        }

        [Test]
        public void MoveTo_StateExists_ReturnsTargetState()
        {
            var targetStateKey = "state1";
            var result = fsm.MoveTo(targetStateKey);
            Assert.AreEqual(targetStateKey, result.Name);
        }

        [Test]
        public void MoveTo_StateNotExists_ThrowsException()
        {
            var targetStateKey = "state3";
            Assert.Throws<KeyNotFoundException>(() => fsm.MoveTo(targetStateKey));
        }

        [Test]
        public void MoveTo_NoCurrentState_ReturnsTargetState()
        {
            var targetStateKey = "state1";
            fsm.CurrentState = null;
            var result = fsm.MoveTo(targetStateKey);
            Assert.AreEqual(targetStateKey, result.Name);
        }

        [Test]
        public void MoveTo_WithCurrentState_ReturnsNewState()
        {
            var initialStateKey = "state1";
            fsm.MoveTo(initialStateKey);
            var targetStateKey = "state2";
            var result = fsm.MoveTo(targetStateKey);
            Assert.AreEqual(targetStateKey, result.Name);
        }
    }
}
