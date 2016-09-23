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
            return new FacingNorth();
        }

        public IPosition TurnRight()
        {
            return   new FacingSouth();
        }
    }
}