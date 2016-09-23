namespace MarsRover.Src
{
    public class FacingWest : IPosition
    {
        public void Move(Position position)
        {
            position._xaxis -= 1;
        }
    }
}