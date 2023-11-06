// Your code starts here

using NUnit.Framework;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateBeganEventArgs_FiniteStateEndedEventArgs_8c2093187a
    {
        [Test]
        public void FiniteStateEndedEventArgs_WithValidInput_InitializesTypeSuccessfully()
        {
            // Arrange
            var stateType = StateType.StateType1;

            // Act
            var endedEventArgs = new FiniteStateEndedEventArgs(stateType);

            // Assert
            Assert.IsNotNull(endedEventArgs);
            Assert.AreEqual(stateType, endedEventArgs.Type);
        }

        [Test]
        public void FiniteStateEndedEventArgs_WithNullInput_ThrowsArgumentNullException()
        {
            // Arrange
            StateType stateType = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new FiniteStateEndedEventArgs(stateType));
        }
    }
}

// Your code ends here
