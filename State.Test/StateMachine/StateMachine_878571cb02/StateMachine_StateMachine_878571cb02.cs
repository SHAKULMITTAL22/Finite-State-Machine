using NUnit.Framework;
using System;
using FiniteStateMachine;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachine_StateMachine_878571cb02
    {
        [Test]
        public void InitializeStateMachine_StatesDictionaryNotEmpty()
        {
            // Arrange & Act
            var stateMachine = new StateMachine<int>();

            // Assert
            Assert.That(stateMachine.States, Is.Not.Empty, "The state machine should be initialized with states.");
        }

        [Test]
        public void InitializeStateMachine_InitialStateIsCorrect()
        {
            // Arrange
            var initialState = 0;

            // Act
            var stateMachine = new StateMachine<int>();

            // Assert
            Assert.That(stateMachine.CurrentState, Is.EqualTo(initialState), "The state machine should be initialized with the correct initial state.");
        }

        [Test]
        public void InitializeStateMachine_StatesDictionaryCountCorrect()
        {
            // Arrange
            int expectedStatesCount = 2;

            // Act
            var stateMachine = new StateMachine<int>();

            // Assert
            Assert.That(stateMachine.States.Count, Is.EqualTo(expectedStatesCount), "The state machine should be initialized with correct number of states.");
        }
    }
}
