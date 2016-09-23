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
            return new FacingWest();
        }

        public IPosition TurnRight()
        {
            return  new FacingEast();
        }
    }
}