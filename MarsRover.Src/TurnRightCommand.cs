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