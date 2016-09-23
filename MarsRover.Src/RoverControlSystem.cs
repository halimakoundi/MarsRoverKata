using MarsRover.Src.Parser;
using MarsRover.Src.Rover_Elements;

namespace MarsRover.Src
{
    public class RoverControlSystem
    {
        private readonly UIPrinter _uiPrinter;
        private readonly CommandParser _parser;
        private readonly Rover _rover;

        public RoverControlSystem(Rover rover, UIPrinter uiPrinter, CommandParser parser)
        {
            _rover = rover;
            _uiPrinter = uiPrinter;
            _parser = parser;
        }

        public void Handle( string instructions)
        {
            var newPosition = _rover.Execute(_parser.Parse(instructions));
            _uiPrinter.WriteLine(newPosition);
        }
    }
}