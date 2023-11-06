// This is the regenerated c# nunit test case
using NUnit.Framework;
using Moq;
using FiniteStateMachine;

namespace FiniteStateMachine.Tests
{
    [TestFixture]
    public class StateMachine_Update_igja2323cc 
    {
        private Mock<IState> _mockState;
        private StateMachine _stateMachine;

        [SetUp]
        public void Setup()
        {
            _mockState = new Mock<IState>();
            _stateMachine = new StateMachine();
        }

        [Test]
        public void Update_StateIsNull_NothingHappens()
        {
            _stateMachine.Update(1.0f);
            _mockState.Verify(m => m._Update(It.IsAny<float>()), Times.Never);
        }

        [Test]
        public void Update_StateExists_StateUpdateCalled() 
        {
            _stateMachine.SetState(_mockState.Object);
            _stateMachine.Update(1.0f);
            _mockState.Verify(m => m._Update(It.IsAny<float>()), Times.Once);
        }

        [Test]
        public void Update_StateExistsDeltaTimePositive_UpdateWithDeltaTimeCalled() 
        {
            float expectedDeltaTime = 1.0f;
            _stateMachine.SetState(_mockState.Object);
            _stateMachine.Update(expectedDeltaTime);
            _mockState.Verify(m => m._Update(expectedDeltaTime), Times.Once);
        }
    }
}
