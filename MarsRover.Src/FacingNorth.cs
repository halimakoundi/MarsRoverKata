namespace MarsRover.Src
{
    public class FacingNorth : IPosition
    {
        public void Move(Position position)
        {
            position._yaxis += 1;
        }

        public IPosition TurnLeft()
        {
            return new FacingEast();
        }

        public IPosition TurnRight()
        {
            return new FacingWest();
        }
    }
}