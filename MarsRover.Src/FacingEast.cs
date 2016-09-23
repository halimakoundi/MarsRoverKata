namespace MarsRover.Src
{
    public class FacingEast : IPosition
    {
        public Coordinates Coords { get; }

        public FacingEast(Coordinates coords)
        {
            Coords = coords;
        }

        public void Move()
        {
            Coords.MoveForward();
        }

        public IPosition TurnLeft()
        {
            return new FacingNorth(Coords);
        }

        public IPosition TurnRight()
        {
            return   new FacingSouth(Coords);
        }

        public string CardinalPosition { get; } = "E";
    }
}