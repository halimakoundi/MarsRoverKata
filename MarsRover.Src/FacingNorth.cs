namespace MarsRover.Src
{
    public class FacingNorth : IPosition
    {
        public void Move(Position position)
        {
            position._yaxis += 1;
        }
    }
}