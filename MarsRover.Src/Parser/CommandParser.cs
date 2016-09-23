using System.Linq;
using MarsRover.Src.Comands;

namespace MarsRover.Src.Parser
{
    public class CommandParser
    {
        public RoverCommands Parse(string instructions)
        {
            var commands = new RoverCommands();
            instructions.ToList().ForEach(
                i => commands.Add(ParseCommand(i)));
            return commands;
        }

        private static IRoverCommand ParseCommand(char command)
        {
            switch (command)
            {
                case 'M':
                    return new MoveCommand();
                case 'L':
                    return new TurnLeftCommand();
                case 'R':
                    return new TurnRightCommand();
            }
            return null;
        }
    }
}