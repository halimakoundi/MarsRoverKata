namespace MarsRover.Src
{
    public class Position
    {
        private int _yaxis;
        private int _xaxis;
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
            switch (_cardinalPosition.GetValue())
            {
                case Cardinality.N:
                    MoveUp();
                    break;
                case Cardinality.E:
                    MoveRight();
                    break;
                case Cardinality.W:
                    MoveLeft();
                    break;
                case Cardinality.S:
                    MoveDown();
                    break;
            }
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

        private void MoveDown()
        {
            _yaxis -= 1;
        }

        private void MoveLeft()
        {
            _xaxis -= 1;
        }

        private void MoveRight()
        {
            _xaxis += 1;
        }

        private void MoveUp()
        {
            _yaxis += 1;
        }
    }
}