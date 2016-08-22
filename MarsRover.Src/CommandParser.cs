namespace MarsRover.Src
{
    public class CommandParser
    {
        public static RoverCommands Parse(string instructions)
        {
            var commands = new RoverCommands();
            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'M':
                        commands.Add(new MoveCommand());
                        break;
                    case 'L':
                        commands.Add(new TurnLeftCommand());
                        break;
                }
            }
            return commands;
        }
    }
}