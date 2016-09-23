namespace MarsRover.Src
{
    public interface IRoverCommand
    {
        void ApplyTo(Rover rover);
    }
}