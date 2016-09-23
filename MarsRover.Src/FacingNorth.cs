namespace MarsRover.Src
{
    public class FacingNorth : IPosition
    {
        public Coordinates Coords { get; }

        public FacingNorth(Coordinates coords)
        {
            Coords = coords;
        }

        public void Move()
        {
            Coords.MoveUp();
        }

        public IPosition TurnLeft()
        {
            return new FacingWest(Coords);
        }

        public IPosition TurnRight()
        {
            return new FacingEast(Coords);
        }

        public string CardinalPosition { get; } = "N";
    }
}