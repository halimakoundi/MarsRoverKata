namespace MarsRover.Src
{
    public class FacingSouth : IPosition
    {
        public Coordinates Coords { get; }

        public FacingSouth(Coordinates coords)
        {
            Coords = coords;
        }

        public void Move(Position position)
        {
            position._yaxis -= 1;
            Coords.MoveDown();
        }

        public IPosition TurnLeft()
        {
            return new FacingEast(Coords);
        }

        public IPosition TurnRight()
        {
            return  new FacingWest(Coords);
        }

        public string CardinalPosition { get; } = "S";
    }
}