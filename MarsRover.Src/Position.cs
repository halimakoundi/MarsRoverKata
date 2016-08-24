using System;

namespace MarsRover.Src
{
    public class Position
    {
        public void Parse(string position)
        {
            var positions = position.Split(' ');
            if (positions.Length < 3)
            {
                throw new Exception("Invalid coordinates provided.");
            }
            Xaxis = int.Parse(positions[0]);
            Yaxis = int.Parse(positions[1]);
            CardinalPosition = new Cardinality(positions[2]);
        }

        public Cardinality CardinalPosition { get; private set; }

        public int Yaxis { get; private set; }

        public int Xaxis { get; private set; }

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

        private void MoveDown()
        {
            Yaxis -= 1;
        }

        private void MoveLeft()
        {
            Xaxis -= 1;
        }

        private void MoveRight()
        {
            Xaxis += 1;
        }

        private void MoveUp()
        {
            Yaxis += 1;
        }

        public override string ToString() => $"{Xaxis} {Yaxis} {CardinalPosition}";

        public void TurnLeft()
        {
            TurnLeftFromPosition();
        }

        private void TurnLeftFromPosition()
        {
            CardinalPosition.Left();
        }

        public void TurnRight()
        {
            CardinalPosition.Right();

        }
    }
    }