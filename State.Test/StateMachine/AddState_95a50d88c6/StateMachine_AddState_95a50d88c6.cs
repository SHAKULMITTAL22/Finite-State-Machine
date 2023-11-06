using NUnit.Framework;
using Moq;
using FiniteStateMachine;
using System;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachine_AddState_95a50d88c6
    {
        private StateMachine<string> _stateMachine;

        [SetUp]
        public void SetUp()
        {
            _stateMachine = new StateMachine<string>();
        }

        [Test]
        public void AddState_ValidState_AddedSuccessfully()
        {
            // Arrange
            var stateMock = new Mock<State<string>>();
            stateMock.Setup(s => s.StateMachine).Returns(_stateMachine);
            stateMock.Setup(s => s.StateKey).Returns("validState");

            // Act
            _stateMachine.AddState(stateMock.Object);

            // Assert
            var statesDict = _stateMachine.States;
            Assert.IsTrue(statesDict.ContainsKey("validState"));
            Assert.AreSame(stateMock.Object, statesDict["validState"]);
        }

        [Test]
        public void AddState_InvalidState_ThrowsException()
        {
            // Arrange
            var otherStateMachine = new StateMachine<string>();
            var stateMock = new Mock<State<string>>();
            stateMock.Setup(s => s.StateMachine).Returns(otherStateMachine);
            stateMock.Setup(s => s.StateKey).Returns("invalidState");

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _stateMachine.AddState(stateMock.Object));
            Assert.AreEqual("[FiniteStateMachine::AddState()] -> The State can only be added to the State Machine that was used to create it.", ex.Message);
        }
    }
}
