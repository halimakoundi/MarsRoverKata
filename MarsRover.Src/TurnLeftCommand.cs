namespace MarsRover.Src
{
    public class TurnLeftCommand : RoverCommand
    {
        public void ApplyTo(Position position)
        {
            position.TurnLeft();
        }
    }
}