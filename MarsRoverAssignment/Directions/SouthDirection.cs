namespace MarsRoverAssignment
{
    public class SouthDirection : Direction
    {

        public override Direction spinRight()
        {
            return new WestDirection();
        }

        public override Direction spinLeft()
        {
            return new EastDirection();
        }

        public override void moveForward(Rover rover)
        {
            rover.setCoordinateY(rover.getCoordinateY() - 1);
        }

        public override void moveBack(Rover rover)
        {
            rover.setCoordinateY(rover.getCoordinateY() + 1);
        }       

    }
}