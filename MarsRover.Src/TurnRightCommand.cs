namespace MarsRover.Src
{
    public class TurnRightCommand : IRoverCommand
    {
        public void ApplyTo(Position position)
        {
            position.TurnRight();
        }
    }
}