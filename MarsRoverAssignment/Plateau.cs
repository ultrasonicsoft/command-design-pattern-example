using System;
namespace MarsRoverAssignment
{
    public class Plateau
    {
        private const int lowerBoundCoordinateX = 0;
        private const int lowerBoundCoordinateY = 0;
        private readonly int upperBoundCoordinateX;
        private readonly int upperBoundCoordinateY;

        public Plateau(int upperBoundCoordinateX, int upperBoundCoordinateY)
        {
            this.upperBoundCoordinateX = upperBoundCoordinateX;
            this.upperBoundCoordinateY = upperBoundCoordinateY;
        }

        public int getUpperBoundCoordinateX()
        {
            return upperBoundCoordinateX;
        }

        public int getUpperBoundCoordinateY()
        {
            return upperBoundCoordinateY;
        }

        public int getLowerBoundCoordinateX()
        {
            return lowerBoundCoordinateX;
        }

        public int getLowerBoundCoordinateY()
        {
            return lowerBoundCoordinateY;
        }
    }
}
