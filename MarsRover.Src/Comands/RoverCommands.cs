using System.Collections.Generic;
using MarsRover.Src.Rover_Elements;

namespace MarsRover.Src.Comands
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