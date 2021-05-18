using System;
using System.Collections.Generic;

namespace MarsRoverAssignment
{
    public class InputUtil
    {

        public static Plateau parsePlateauInput(String plateauInput)
        {
            String[] inputArray = plateauInput.Split(" ");
            int plateauUpperBoundCoordinateX = int.Parse(inputArray[0]);
            int plateauUpperBoundCoordinateY = int.Parse(inputArray[1]);
            return new Plateau(plateauUpperBoundCoordinateX, plateauUpperBoundCoordinateY);
        }

        public static List<String> BuildCmdList()
        {
            //var cmdList = new ArrayList<>();
            List<String> cmdList = new List<String>();
            cmdList.Add("5 5");
            cmdList.Add("1 2 N");
            cmdList.Add("LMLMLMLMM");
            cmdList.Add("3 3 E");
            cmdList.Add("MMRMMRMRRM");


            return cmdList;
        }

        public static Rover parsePositionInput(String positionInput, Plateau plateau)
        {
            String[] inputArray = positionInput.Split(" ");
            int roverLandingCoordinateX = int.Parse(inputArray[0]);
            int roverLandingCoordinateY = int.Parse(inputArray[1]);
            Direction direction = DirectionLookup.GetDirection(inputArray[2]);
            return new Rover(plateau, roverLandingCoordinateX, roverLandingCoordinateY, direction);
        }

        public static List<Command> parseCommandInput(String command)
        {
            char[] inputArray = command.ToCharArray();
            List<Command> commandArrayList = new List<Command>();

            foreach (char character in inputArray)
            {
                Command currentCommand = CommandLookup.GetCommand(character.ToString());
                commandArrayList.Add(currentCommand);
            }

            return commandArrayList;
        }
    }
}
