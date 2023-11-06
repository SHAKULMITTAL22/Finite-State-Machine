// Test generated by RoostGPT for test roost-test using AI Type Azure Open AI and AI Model roost-gpt4-32k

using NUnit.Framework;
using System;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateBeganEventArgs_FiniteStateBeganEventArgs_9169a2778c
    {
        [Test] 
        public void Test_FiniteStateBeganEventArgs_WithValidState()
        {
            var state = StateType.Valid; 
            var args = new FiniteStateBeganEventArgs(state);

            Assert.IsNotNull(args);
            Assert.AreEqual(state, args.Type);
        }

        [Test]
        public void Test_FiniteStateBeganEventArgs_WithInvalidState()
        {
            var state = StateType.Invalid;
            var args = new FiniteStateBeganEventArgs(state);

            Assert.IsNotNull(args);
            Assert.AreEqual(state, args.Type);
        }

        [Test]
        public void Test_FiniteStateBeganEventArgs_WithNullState() //Edge case
        {
            StateType state = null;
            
            Assert.Throws<ArgumentNullException>(() => new FiniteStateBeganEventArgs(state));
        }
    }
}
