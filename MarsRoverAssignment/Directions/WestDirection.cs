namespace MarsRoverAssignment
{
    public class WestDirection : Direction
    {

        public override Direction spinRight()
        {
            return new NorthDirection();
        }

        public override Direction spinLeft()
        {
            return new SouthDirection();
        }

        public override void moveForward(Rover rover)
        {
            rover.setCoordinateX(rover.getCoordinateX() - 1);
        }

        public override void moveBack(Rover rover)
        {
            rover.setCoordinateX(rover.getCoordinateX() + 1);
        }        

    }
}