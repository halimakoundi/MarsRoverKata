namespace MarsRover.Src
{
    public class Position
    {
        public int _yaxis;
        public int _xaxis;
        private CardinalPosition _cardinalPosition;
        public IPosition _position;

        public Position(string position)
        {
            var positions = Parse(position);
            SetAxis(positions);
            SetCardinalPosition(positions);
        }

        private void SetCardinalPosition(string[] positions)
        {
            _cardinalPosition = new CardinalPosition(positions[2]);
            switch (_cardinalPosition.GetValue())
            {
                case Cardinality.N:
                    _position = new FacingNorth();
                    break;
                case Cardinality.E:
                    _position = new FacingEast();
                    break;
                case Cardinality.W:
                    _position = new FacingWest();
                    break;
                case Cardinality.S:
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
            switch (_cardinalPosition.GetValue())
            {
                case Cardinality.N:
                    _position = new FacingNorth();
                    break;
                case Cardinality.E:
                    _position = new FacingEast();
                    break;
                case Cardinality.W:
                    _position = new FacingWest();
                    break;
                case Cardinality.S:
                    _position = new FacingSouth();
                    break;
            }
            _position.Move(this);
        }

        public void TurnLeft()
        {
            _cardinalPosition.Left();
            _position = _position.TurnLeft();
        }

        public void TurnRight()
        {
            _cardinalPosition.Right();
            _position = _position.TurnRight();
        }

        public override string ToString() => $"{_xaxis} {_yaxis} {_cardinalPosition}";
    }

    public interface IPosition
    {
        void Move(Position position);
        IPosition TurnLeft();
        IPosition TurnRight();
    }
}