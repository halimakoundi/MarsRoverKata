using System;

namespace MarsRover.Src
{
    public class MoveCommand : RoverCommand
    {
        public void ApplyTo(Position position)
        {
            position.Move();
        }
    }
}