namespace MarsRover.Src
{
    public interface RoverCommand
    {
        void ApplyTo(Position position);
    }
}