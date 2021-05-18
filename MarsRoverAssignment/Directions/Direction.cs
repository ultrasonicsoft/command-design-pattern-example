namespace MarsRoverAssignment
{
    public abstract class Direction
    {
        public abstract Direction spinRight();

        public abstract Direction spinLeft();

        public abstract void moveForward(Rover rover);

        public abstract void moveBack(Rover rover);
    }
}