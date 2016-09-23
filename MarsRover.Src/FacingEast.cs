namespace MarsRover.Src
{
    public class FacingEast : IPosition
    {
        public void Move(Position position)
        {
            position._xaxis += 1;
        }
    }
}