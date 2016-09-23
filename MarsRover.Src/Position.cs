namespace MarsRover.Src
{
    public class Position
    {
        public int _yaxis;
        public int _xaxis;
        public IPosition _position;

        public Position(string position)
        {
            var positions = Parse(position);
            SetAxis(positions);
            SetCardinalPosition(positions);
        }

        private void SetCardinalPosition(string[] positions)
        {
            switch (positions[2])
            {
                case "N":
                    _position = new FacingNorth();
                    break;
                case "E":
                    _position = new FacingEast();
                    break;
                case "W":
                    _position = new FacingWest();
                    break;
                case "S":
                    _position = new FacingSouth();
                    break;
            }
        }

        private void SetAxis(string[] positions)
        {
            _xaxis = int.Parse(positions[0]);
            _yaxis = int.Parse(positions[1]);
        }

        private static string[] Parse(string position)
        {
            var positions = position.Split(' ');
            return positions;
        }

        public void Move()
        {
            _position.Move(this);
        }

        public void TurnLeft()
        {
            _position = _position.TurnLeft();
        }

        public void TurnRight()
        {
            _position = _position.TurnRight();
        }

        public override string ToString() => $"{_xaxis} {_yaxis} {_position.CardinalPosition}";
    }

    public interface IPosition
    {
        void Move(Position position);
        IPosition TurnLeft();
        IPosition TurnRight();
        string CardinalPosition { get; }
    }
}