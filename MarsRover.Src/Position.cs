namespace MarsRover.Src
{
    public class Position
    {
        public IPosition _position;
        private Coordinates _coords;

        public Position(string position)
        {
            var positions = Parse(position);
            SetAxis(positions);
            SetInitialCardinalPosition(positions);
        }

        private void SetInitialCardinalPosition(string[] positions)
        {
            switch (positions[2])
            {
                case "N":
                    _position = new FacingNorth(_coords);
                    break;
                case "E":
                    _position = new FacingEast(_coords);
                    break;
                case "W":
                    _position = new FacingWest(_coords);
                    break;
                case "S":
                    _position = new FacingSouth(_coords);
                    break;
            }
        }

        private void SetAxis(string[] positions)
        {
            _coords = new Coordinates(int.Parse(positions[0]), int.Parse(positions[1]));
        }

        private static string[] Parse(string position)
        {
            var positions = position.Split(' ');
            return positions;
        }

        public void Move()
        {
            _position.Move();
        }

        public void TurnLeft()
        {
            _position = _position.TurnLeft();
        }

        public void TurnRight()
        {
            _position = _position.TurnRight();
        }

        public override string ToString() => $"{_position.Coords.Display()} {_position.CardinalPosition}";
    }

    public interface IPosition
    {
        void Move();
        IPosition TurnLeft();
        IPosition TurnRight();
        string CardinalPosition { get; }
        Coordinates Coords { get; }
    }
}