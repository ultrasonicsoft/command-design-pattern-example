using System;
using System.Collections.Generic;

namespace MarsRoverAssignment
{
    class Program
    {
        static void Main(string[] args)
        {            
            var commandList = InputUtil.BuildCmdList();

            String[] plateaUpper = commandList[0].ToString().Split(" ");

            Plateau plateau = new Plateau(Int32.Parse(plateaUpper[0]), Int32.Parse(plateaUpper[1]));

            List<String> roverInput = commandList.GetRange(1, commandList.Count - 1);

            for (int commandIndex = 0; commandIndex < roverInput.Count; commandIndex += 2)
            {
                Rover rover = InputUtil.parsePositionInput(roverInput[commandIndex], plateau);
                List<Command> commands = InputUtil.parseCommandInput(roverInput[commandIndex + 1]);
                rover.executeCommandList(commands);
                Console.WriteLine(rover.broadcastLocation());
            }
        }
        
    }
}
