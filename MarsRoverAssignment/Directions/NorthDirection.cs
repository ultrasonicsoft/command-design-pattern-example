namespace MarsRoverAssignment
{

    public class NorthDirection : Direction
    {
        public const string DirectionKey = "N";

        public override Direction spinRight()
        {
            return new EastDirection();
        }

        public override Direction spinLeft()
        {
            return new WestDirection();
        }

        public override void moveForward(Rover rover)
        {
            rover.setCoordinateY(rover.getCoordinateY() + 1);
        }

        public override void moveBack(Rover rover)
        {
            rover.setCoordinateY(rover.getCoordinateY() - 1);
        }
        
    }

}