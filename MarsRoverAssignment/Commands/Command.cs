using System;

namespace MarsRoverAssignment
{
    public abstract class Command
    {
        public abstract void execute(Rover rover);        
    }
}