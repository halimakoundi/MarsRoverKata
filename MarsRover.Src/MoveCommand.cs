namespace MarsRover.Src
{
    public class MoveCommand : IRoverCommand
    {
        public void ApplyTo(Rover rover)
        {
            rover.Move();
        }
    }
}