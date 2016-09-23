namespace MarsRover.Src
{
    public class Position
    {
        public int _yaxis;
        public int _xaxis;
        private CardinalPosition _cardinalPosition;

        public Position(string position)
        {
            var positions = Parse(position);
            SetAxis(positions);
            SetCardinalPosition(positions);
        }

        private void SetCardinalPosition(string[] positions)
        {
            _cardinalPosition = new CardinalPosition(positions[2]);
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
            IPosition position = null;
            switch (_cardinalPosition.GetValue())
            {
                case Cardinality.N:
                    position = new FacingNorth();
                    break;
                case Cardinality.E:
                    position = new FacingEast();
                    break;
                case Cardinality.W:
                    position = new FacingWest();
                    break;
                case Cardinality.S:
                    position = new FacingSouth();
                    break;
            }
            position.Move(this);
        }

        public void TurnLeft()
        {
            _cardinalPosition.Left();
        }

        public void TurnRight()
        {
            _cardinalPosition.Right();

        }

        public override string ToString() => $"{_xaxis} {_yaxis} {_cardinalPosition}";
    }

    public interface IPosition
    {
        void Move(Position position);
    }
}