// Test generated by RoostGPT for test roost-test using AI Type Azure Open AI and AI Model roost-gpt4-32k

using NUnit.Framework;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class State_State_f11a4f0491
    {
        private StateMachine<string> _fsm;
        private State<string> _state;
        
        [SetUp]
        public void Setup()
        {
            _fsm = new StateMachine<string>();
            _state = new State<string>(_fsm, "StateKey");
        }
        
        [Test]
        public void State_ShouldSetStateMachine()
        {
            Assert.That(_state.StateMachine, Is.EqualTo(_fsm));
        }

        [Test]
        public void State_ShouldSetStateKey()
        {
            Assert.That(_state.StateKey, Is.EqualTo("StateKey"));
        }

        [Test]
        public void State_ShouldThrowException_WhenFsmIsNull()
        {
            Assert.Throws<System.ArgumentNullException>(() => { _state = new State<string>(null, "StateKey"); });
        }

        [Test]
        public void State_ShouldThrowException_WhenStateKeyIsNull()
        {
            Assert.Throws<System.ArgumentNullException>(() => { _state = new State<string>(_fsm, null); });
        }
    }
}
