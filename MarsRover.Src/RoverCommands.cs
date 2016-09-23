using System.Collections.Generic;

namespace MarsRover.Src
{
    public class RoverCommands
    {
        private readonly List<IRoverCommand> _commands;

        public RoverCommands()
        {
            _commands = new List<IRoverCommand>();
        }

        public void Add(IRoverCommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands(Rover rover)
        {
            _commands.ForEach(c => c.ApplyTo(rover));
        }
    }
}