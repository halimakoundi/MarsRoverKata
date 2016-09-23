namespace MarsRover.Src
{
    public class FacingWest : IPosition
    {
        public void Move(Position position)
        {
            position._xaxis -= 1;
        }

        public IPosition TurnLeft()
        {
            return new FacingSouth();
        }

        public IPosition TurnRight()
        {
            return   new FacingNorth();
        }

        public string CardinalPosition { get; } = "W";
    }
}