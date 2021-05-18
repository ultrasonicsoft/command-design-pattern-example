using System;
using System.Collections.Generic;

namespace MarsRoverAssignment
{
    public class Rover
    {
        private readonly Plateau plateau;
        private int coordinateX;
        private int coordinateY;
        private Direction direction;

        public Rover(Plateau plateau, int coordinateX, int coordinateY, Direction direction)
        {
            if (plateau == null) throw new Exception("The Plateau you create the Rover in cannot be null!");
            if (direction == null) throw new Exception("The Direction the Rover is facing in cannot be null!");

            this.plateau = plateau;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.direction = direction;

            validateLocation();
        }

        private Plateau getPlateau()
        {
            return plateau;
        }

        public int getCoordinateX()
        {
            return coordinateX;
        }

        public void setCoordinateX(int coordinateX)
        {
            this.coordinateX = coordinateX;
        }

        public int getCoordinateY()
        {
            return coordinateY;
        }

        public void setCoordinateY(int coordinateY)
        {
            this.coordinateY = coordinateY;
        }

        //public Direction getDirection()
        //{
        //    return direction;
        //}

        public void setDirection(Direction direction)
        {
            this.direction = direction;
        }

        public void executeCommandList(List<Command> commands)
        {
            foreach (Command command in commands)
                command.execute(this);
        }

        public void spinRight()
        {
            direction = this.direction.spinRight();
        }

        public void spinLeft()
        {
            direction = this.direction.spinLeft();
        }

        public void moveForward()
        {
            this.direction.moveForward(this);
            validateLocation();
        }

        public void moveBack()
        {
            this.direction.moveBack(this);
            validateLocation();
        }

        public String broadcastLocation()
        {
            return coordinateX + " "
                    + coordinateY + " "
                    + DirectionLookup.GetDirectionKey(this.direction);            
        }

        private void validateLocation()
        {
            if (this.getCoordinateX() > this.getPlateau().getUpperBoundCoordinateX()
                    || this.getCoordinateY() > this.getPlateau().getUpperBoundCoordinateY()
                    || this.getCoordinateX() < this.getPlateau().getLowerBoundCoordinateX()
                    || this.getCoordinateY() < this.getPlateau().getLowerBoundCoordinateY())
                throw new InvalidOperationException("The Rover cannot be out of bounds of the plateau!");
        }
    }
}
