using System;

namespace MarsRover.Src
{
    public class Position
    {
        private int _yaxis;
        private int _xaxis;
        private readonly Cardinality _cardinalPosition;

        public Position(string position)
        {
            var positions = Parse(position);
            SetAxis(positions);
            _cardinalPosition = new Cardinality(positions[2]);
        }

        private void SetAxis(string[] positions)
        {
            _xaxis = int.Parse(positions[0]);
            _yaxis = int.Parse(positions[1]);
        }

        private static string[] Parse(string position)
        {
            var positions = position.Split(' ');
            if (positions.Length < 3)
            {
                throw new Exception("Invalid coordinates provided.");
            }
            return positions;
        }

        public void Move()
        {
            switch (_cardinalPosition.GetValue())
            {
                case "N":
                    MoveUp();
                    break;
                case "E":
                    MoveRight();
                    break;
                case "W":
                    MoveLeft();
                    break;
                case "S":
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
            _yaxis = _yaxis - 1;
        }

        private void MoveLeft()
        {
            _xaxis = _xaxis - 1;
        }

        private void MoveRight()
        {
            _xaxis = _xaxis + 1;
        }

        private void MoveUp()
        {
            _yaxis = _yaxis + 1;
        }
    }
}