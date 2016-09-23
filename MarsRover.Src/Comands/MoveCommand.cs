using MarsRover.Src.Rover_Elements;

namespace MarsRover.Src.Comands
{
    public class MoveCommand : IRoverCommand
    {
        public void ApplyTo(Rover rover)
        {
            rover.Move();
        }
    }
}