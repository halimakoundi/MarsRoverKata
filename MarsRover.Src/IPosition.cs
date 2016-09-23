namespace MarsRover.Src
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