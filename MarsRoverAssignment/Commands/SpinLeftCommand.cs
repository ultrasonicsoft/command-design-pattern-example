namespace MarsRoverAssignment
{
    public class SpinLeftCommand : Command
    {
        public override void execute(Rover rover)
        {
            rover.spinLeft();
        }
    }
}