namespace MarsRoverAssignment
{
    public class EastDirection : Direction
    {
        public override Direction spinRight()
        {
            return new SouthDirection();
        }

        public override Direction spinLeft()
        {
            return new NorthDirection();
        }

        public override void moveForward(Rover rover)
        {
            rover.setCoordinateX(rover.getCoordinateX() + 1);
        }

        public override void moveBack(Rover rover)
        {
            rover.setCoordinateX(rover.getCoordinateX() - 1);
        }
    }
}