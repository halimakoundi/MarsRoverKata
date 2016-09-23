namespace MarsRover.Src
{
    public class FacingSouth : IPosition
    {
        public void Move(Position position)
        {
            position._yaxis -= 1;
        }
    }
}