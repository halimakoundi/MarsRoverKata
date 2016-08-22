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
                    case 'R':
                        commands.Add(new TurnRightCommand());
                        break;
                }
            }
            return commands;
        }
    }
}