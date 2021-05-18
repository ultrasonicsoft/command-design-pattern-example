using System;
using MarsRoverAssignment;
using NUnit.Framework;

namespace MarsRoverTest
{
    public class CommandLookupTest
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnSpinLeftCommandByLeftKey()
        {
            var command = CommandLookup.GetCommand("L");
            Assert.IsInstanceOf(typeof(SpinLeftCommand), command);
        }

        [Test]
        public void ShouldThrowInvalidOperationExceptionForInvalidKey()
        {
            Assert.Throws<InvalidOperationException>(() => CommandLookup.GetCommand("X"));
        }
    }
}