using System;
using System.Collections.Generic;

namespace MarsRoverAssignment
{
    public class CommandLookup
    {
        private static readonly Dictionary<string, Command> CommandDictionary;
        static CommandLookup()
        {
            CommandDictionary = new Dictionary<string, Command>
            {
                ["R"] = new SpinRightCommand(),
                ["L"] = new SpinLeftCommand(),
                ["M"] = new MoveForwardCommand(),
                ["B"] = new MoveBackCommand()
            };
        }        

        public static Command GetCommand(string commandKey)
        {
            if (CommandDictionary.ContainsKey(commandKey))
            {
                return CommandDictionary[commandKey];
            }
            throw new InvalidOperationException("Invalid Command Key found");
        }
    }
}