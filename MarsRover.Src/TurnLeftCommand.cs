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