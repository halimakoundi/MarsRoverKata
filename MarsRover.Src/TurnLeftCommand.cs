namespace MarsRover.Src
{
    public class TurnLeftCommand : IRoverCommand
    {
        public void ApplyTo(Position position)
        {
            position.TurnLeft();
        }
    }
}