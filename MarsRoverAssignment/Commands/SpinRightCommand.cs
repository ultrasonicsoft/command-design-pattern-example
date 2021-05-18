namespace MarsRoverAssignment
{
    public class SpinRightCommand : Command
    {
        public override void execute(Rover rover)
        {
            rover.spinRight();
        }
    }
}