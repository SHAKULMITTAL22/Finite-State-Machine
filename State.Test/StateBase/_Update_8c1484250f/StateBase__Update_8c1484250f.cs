using System;
using NUnit.Framework;

namespace FiniteStateMachine.Tests
{
    public class StateBaseTest
    {
        private FakeTimeService _timeService;

        [SetUp]
        public void SetUp()
        {
            _timeService = new FakeTimeService();
        }

        [Test]
        public void Update_WhenCalled_UpdatesWithCorrectDt()
        {
            // Arrange
            var expectedDt = 0.5f;
            _timeService.SetCurrentTime(expectedDt);
            var stateBase = new StateBase(_timeService);
            
            // Act
            stateBase.Update(expectedDt);
            
            // Assert
            Assert.AreEqual(expectedDt, stateBase.Dt);
        }

        [Test]
        public void Update_WhenCalledWithZero_ThrowsArgumentException()
        {
            // Arrange
            var incorrectDt = 0f;
            var stateBase = new StateBase(_timeService);

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => stateBase.Update(incorrectDt));
            Assert.AreEqual("Dt cannot be zero", exception.Message);
        }

        private class FakeTimeService : ITimeService
        {
            private float _currentTime;

            public float GetCurrentTime()
            {
                return _currentTime;
            }

            public void SetCurrentTime(float time)
            {
                _currentTime = time;
            }
        }
    }
}
