using MarsRover.Src.Comands;
using MarsRover.Src.Rover_Elements;

namespace MarsRover.Src
{
    public class TurnRightCommand : IRoverCommand
    {
        public void ApplyTo(Rover rover)
        {
            rover.TurnRight();
        }
    }
}