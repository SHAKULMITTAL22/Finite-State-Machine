// Code regenerated with same logic

using System;
using NUnit.Framework;
using FiniteStateMachine.Test;
using Moq;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateBase__Begin_1ebf58b534_Test 
    {
        private StateBase__Begin_1ebf58b534 stateBase;
        private Mock<FiniteStateChangeEventArgs> mockEventArgs;
        private Mock<StateType> mockStateType;

        [SetUp]
        public void SetUp() 
        {
            stateBase = new StateBase__Begin_1ebf58b534();
            mockEventArgs = new Mock<FiniteStateChangeEventArgs>();
            mockStateType = new Mock<StateType>();
        }

        [Test]
        public void _Begin_Test_AllCallsMade() 
        {
            stateBase._Begin(mockEventArgs.Object, mockStateType.Object);
            
            mockEventArgs.Verify(m => m.OnStateBegan(It.IsAny<FiniteStateBeganEventArgs>()), Times.Once);
            mockStateType.Verify(m => m.Begin(It.IsAny<FiniteStateChangeEventArgs>(), It.IsAny<StateType>()),Times.Once);
        }

        [Test]
        public void _Begin_Test_NullArgumentExceptions() 
        {
            Assert.Throws<ArgumentException>(() => stateBase._Begin(null, mockStateType.Object));
            Assert.Throws<ArgumentException>(() => stateBase._Begin(mockEventArgs.Object, null));
        }

        [TearDown]
        public void TearDown() 
        {
            stateBase = null;
            mockEventArgs = null;
            mockStateType = null;
        }
    }
}
