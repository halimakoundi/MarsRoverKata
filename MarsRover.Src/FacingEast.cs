namespace MarsRover.Src
{
    public class FacingEast : IPosition
    {
        public void Move(Position position)
        {
            position._xaxis += 1;
        }

        public IPosition TurnLeft()
        {
            return new FacingSouth();
        }

        public IPosition TurnRight()
        {
            return   new FacingNorth();
        }
    }
}