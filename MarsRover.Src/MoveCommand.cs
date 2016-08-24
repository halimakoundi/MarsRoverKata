namespace MarsRover.Src
{
    public class MoveCommand : IRoverCommand
    {
        public void ApplyTo(Position position)
        {
            position.Move();
        }
    }
}