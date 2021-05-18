namespace MarsRoverAssignment
{
    public class MoveBackCommand : Command
    {
        public override void execute(Rover rover)
        {
            rover.moveBack();
        }
    }
}