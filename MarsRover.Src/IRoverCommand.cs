namespace MarsRover.Src
{
    public interface IRoverCommand
    {
        void ApplyTo(Position position);
    }
}