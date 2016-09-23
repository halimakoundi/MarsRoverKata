using MarsRover.Src.Rover_Elements;

namespace MarsRover.Src.Comands
{
    public interface IRoverCommand
    {
        void ApplyTo(Rover rover);
    }
}