using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateMachine_MoveTo_e3f88cdb76
    {
        private FiniteStateMachine<StateType> _stateMachine;

        [SetUp]
        public void Setup()
        {
            _stateMachine = new FiniteStateMachine<StateType>();
            // TODO: Define all necessary states and transitions for _stateMachine
        }

        [Test]
        public void MoveTo_NewState_ChangesState()
        {
            // Arrange
            StateType targetStateKey = /* TODO: Choose an appropriate targetStateKey */;

            // Act
            StateType newState = _stateMachine.MoveTo(targetStateKey);

            // Assert
            Assert.AreEqual(targetStateKey, newState);
        }

        [Test]
        public void MoveTo_NewState_FiresOnStateChange()
        {
            // Arrange
            StateType targetStateKey = /* TODO: Choose an appropriate targetStateKey */;
            bool eventFired = false;
            _stateMachine.OnStateChange += (s, e) => eventFired = true;

            // Act
            _stateMachine.MoveTo(targetStateKey);

            // Assert
            Assert.IsTrue(eventFired);
        }
	
        [Test]
        public void MoveTo_SameState_DoesNotFireOnStateChange()
        {
            // Arrange
            StateType currentStateKey = _stateMachine.State;   
            bool eventFired = false;
            _stateMachine.OnStateChange += (s, e) => eventFired = true;

            // Act
            _stateMachine.MoveTo(currentStateKey);

            // Assert
            Assert.IsFalse(eventFired);
        }
    }
}
