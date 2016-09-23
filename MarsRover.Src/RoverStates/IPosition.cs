using MarsRover.Src.Rover_Elements;

namespace MarsRover.Src.RoverStates
{
    public interface IPosition
    {
        void Move();
        IPosition TurnLeft();
        IPosition TurnRight();
        string CardinalPosition { get; }
        Coordinates Coords { get; }
    }
}