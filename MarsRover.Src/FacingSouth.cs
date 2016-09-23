namespace MarsRover.Src
{
    public class FacingSouth : IPosition
    {
        public void Move(Position position)
        {
            position._yaxis -= 1;
        }

        public IPosition TurnLeft()
        {
            return new FacingEast();
        }

        public IPosition TurnRight()
        {
            return  new FacingWest();
        }

        public string CardinalPosition { get; } = "S";
    }
}