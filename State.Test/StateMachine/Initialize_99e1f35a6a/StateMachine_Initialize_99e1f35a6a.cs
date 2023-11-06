using NUnit.Framework;
using System;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    //Test class
    [TestFixture]
    public class StateMachine_Initialize_99e1f35a6a
    {
        private FiniteStateMachine _stateMachine;

        [SetUp]
        public void Setup()
        {
            _stateMachine = new FiniteStateMachine();
        }

        [TearDown]
        public void Cleanup()
        {
            _stateMachine = null;
        }

        //Test case 1: Check the Initialize function works properly
        [Test]
        public void Initialize_WhenCalled_ShouldNotThrowException()
        {
            //Act and Assert
            Assert.DoesNotThrow(() => _stateMachine.Initialize());
        }

        //Test case 2: Validate that Initialize function updates the internal state
        [Test]
        public void Initialize_WhenCalled_StateShouldNotBeNullOrUndefined()
        {
            
            //Act 
            _stateMachine.Initialize();

            //Assert
            Assert.IsNotNull(_stateMachine.State);
        }
    }
}
