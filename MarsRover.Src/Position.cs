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
            CardinalPosition = positions[2];
        }

        public string CardinalPosition { get; private set; }

        public int Yaxis { get; private set; }

        public int Xaxis { get; private set; }

        public void Move()
        {
            switch (CardinalPosition)
            {
                case "N":
                    Yaxis += 1;
                    break;
                case "E":
                    Xaxis += 1;
                    break;
                case "W":
                    Xaxis -= 1;
                    break;
                case "S":
                    Yaxis -= 1;
                    break;
            }
        }

        public override string ToString() => $"{Xaxis} {Yaxis} {CardinalPosition}";

        public void TurnLeft()
        {
            switch (CardinalPosition)
            {
                case "N":
                    CardinalPosition = "W";
                    break;
                case "E":
                    CardinalPosition = "N";
                    break;
                case "W":
                    CardinalPosition = "S";
                    break;
                case "S":
                    CardinalPosition = "E";
                    break;
            }
        }

        public void TurnRight()
        {
            switch (CardinalPosition)
            {
                case "N":
                    CardinalPosition = "E";
                    break;
                case "E":
                    CardinalPosition = "S";
                    break;
                case "S":
                    CardinalPosition = "W";
                    break;
                case "W":
                    CardinalPosition = "N";
                    break;
            }
        }
    }
}