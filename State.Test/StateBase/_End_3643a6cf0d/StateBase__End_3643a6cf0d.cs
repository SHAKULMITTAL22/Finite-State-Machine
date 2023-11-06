using System;
using NUnit.Framework;
using FiniteStateMachine;
using System.Reflection;
using System.Threading;

namespace FiniteStateMachine.Test
{
    public class StateBase__End_3643a6cf0d
    {
        private StateBase _stateBase;
        private FiniteStateMachine _finiteStateMachine;

        [SetUp]
        public void Setup()
        {
            // Initialize FiniteStateMachine
            _finiteStateMachine = (FiniteStateMachine)Activator.CreateInstance(typeof(FiniteStateMachine), BindingFlags.Instance | BindingFlags.NonPublic, null, null, null);
            Assert.IsNotNull(_finiteStateMachine, "Failed to initialize FiniteStateMachine");

            // Initialize StateBase
            _stateBase = (StateBase)Activator.CreateInstance(typeof(StateBase), BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { "Test" }, null);
            Assert.IsNotNull(_stateBase, "Failed to initialize StateBase");
        }

        [Test]
        public void _End_StateNotEnded_EndsQuickly()
        {
            bool eventTriggered = false;
            using (AutoResetEvent autoResetEvent = new AutoResetEvent(false))
            {
                _finiteStateMachine.OnStateEnded += (i) => {
                    eventTriggered = true;
                    autoResetEvent.Set();
                };

                _stateBase.End();

                bool received = autoResetEvent.WaitOne(TimeSpan.FromSeconds(1));
                Assert.IsTrue(received, "_End should complete quickly");
                Assert.IsTrue(eventTriggered, "_End did not trigger OnStateEnded event");
            }
        }

        [Test]
        public void _End_StateAlreadyEnded_DoesNotTriggerEventTwice()
        {
            int eventCount = 0;
            using (AutoResetEvent autoResetEvent = new AutoResetEvent(false))
            {
                _finiteStateMachine.OnStateEnded += (i) => {
                    eventCount++;
                    autoResetEvent.Set();
                };

                // Call End twice
                _stateBase.End();
                _stateBase.End();

                bool received = autoResetEvent.WaitOne(TimeSpan.FromSeconds(1));
                Assert.IsTrue(received, "_End should complete quickly");
                Assert.AreEqual(1, eventCount, "_End should not trigger OnStateEnded event more than once");
            }
        }
    }
}
