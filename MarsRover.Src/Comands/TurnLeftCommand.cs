using MarsRover.Src.Comands;
using MarsRover.Src.Rover_Elements;

namespace MarsRover.Src
{
    public class TurnLeftCommand : IRoverCommand
    {
        public void ApplyTo(Rover rover)
        {
            rover.TurnLeft();
        }
    }
}