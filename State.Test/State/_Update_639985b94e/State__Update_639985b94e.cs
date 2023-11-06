using System;
using NUnit.Framework;
using Moq;
using FiniteStateMachine;

namespace FiniteStateMachine.Tests
{
    [TestFixture]
    public class State_Update_639985b94e
    {
        private Mock<IMethod> _mockMethod;

        [SetUp]
        public void SetUp()
        {
            _mockMethod = new Mock<IMethod>();
        }

        [Test]
        public void Update_WithPositiveDeltaTime_ExpectUpdateMethodCalled()
        {
            // Arrange
            State state = new State(_mockMethod.Object);
            float deltaTime = 2.0f;

            //Act
            state._Update(deltaTime);

            //Assert
            _mockMethod.Verify(x => x.Update(deltaTime), Times.Once);
        }

        [Test]
        public void Update_WithNegativeDeltaTime_ExpectUpdateMethodCalled()
        {
            // Arrange
            State state = new State(_mockMethod.Object);
            float deltaTime = -1.0f;

            //Act
            state._Update(deltaTime);

            //Assert
            _mockMethod.Verify(x => x.Update(deltaTime), Times.Once);
        }

        [Test]
        public void Update_WithZeroDeltaTime_ExpectUpdateMethodCalled()
        {
            // Arrange
            State state = new State(_mockMethod.Object);
            float deltaTime = 0.0f;

            //Act
            state._Update(deltaTime);

            //Assert
            _mockMethod.Verify(x => x.Update(deltaTime), Times.Once);
        }
    }
}
