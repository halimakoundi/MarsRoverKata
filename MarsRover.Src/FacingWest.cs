namespace MarsRover.Src
{
    public class FacingWest : IPosition
    {
        public string CardinalPosition { get; } = "W";
        public Coordinates Coords { get; }

        public FacingWest(Coordinates coords)
        {
            Coords = coords;
        }

        public void Move()
        {
            Coords.MoveBackward();
        }

        public IPosition TurnLeft()
        {
            return new FacingSouth(Coords);
        }

        public IPosition TurnRight()
        {
            return   new FacingNorth(Coords);
        }
    }
}