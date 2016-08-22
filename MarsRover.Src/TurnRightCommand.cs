namespace MarsRover.Src
{
    public class TurnRightCommand : RoverCommand
    {
        public void ApplyTo(Position position)
        {
            position.TurnRight();
        }
    }
}