using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    public class FiniteStateMachine_Update_97a3df38bc
    {
        private Mock<FiniteStateMachine> _finiteStateMachineMock;

        [SetUp]
        public void Setup()
        {
            _finiteStateMachineMock = new Mock<FiniteStateMachine>();
        }

        // Test case to validate correct deltaTime accumulation
        [Test]
        public void Test_Update_WhenCalled_ShouldCorrectlyAccumulateDeltaTime()
        {
            // Arrange
            var deltaTime = 2.5f;

            // Act
            _finiteStateMachineMock.Object.Update(deltaTime);

            // Assert
            Assert.AreEqual(deltaTime, _finiteStateMachineMock.Object.AccumulatedTime);
        }

        // Test case to validate that the base method is called once during the Update call.
        [Test]
        public void Test_Update_WhenCalled_ShouldCallBaseUpdate()
        {
            // Arrange
            var deltaTime = 2.5f;

            // Act
            _finiteStateMachineMock.Object.Update(deltaTime);

            // Assert
            _finiteStateMachineMock.Verify(mock => mock.Update(It.IsAny<float>()), Times.Once());
        }

        [TearDown]
        public void Cleanup()
        {
            _finiteStateMachineMock = null;
        }

    }
}
