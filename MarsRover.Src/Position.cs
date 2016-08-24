using System;

namespace MarsRover.Src
{
    public class Position
    {
        private int _yaxis;
        private int _xaxis;

        public void Parse(string position)
        {
            var positions = position.Split(' ');
            if (positions.Length < 3)
            {
                throw new Exception("Invalid coordinates provided.");
            }
            _xaxis = int.Parse(positions[0]);
            _yaxis = int.Parse(positions[1]);
            CardinalPosition = new Cardinality(positions[2]);
        }

        private Cardinality CardinalPosition { get; set; }

        public void Move()
        {
            switch (CardinalPosition.GetValue())
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
            CardinalPosition.Left();
        }

        public void TurnRight()
        {
            CardinalPosition.Right();

        }

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

        public override string ToString() => $"{_xaxis} {_yaxis} {CardinalPosition}";
    }
}