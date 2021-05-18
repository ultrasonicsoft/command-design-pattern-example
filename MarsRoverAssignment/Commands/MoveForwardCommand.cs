namespace MarsRoverAssignment
{
    public class MoveForwardCommand : Command
    {
        public override void execute(Rover rover)
        {
            rover.moveForward();
        }
    }
}