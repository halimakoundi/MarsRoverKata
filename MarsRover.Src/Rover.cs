using System;
using System.Collections.Generic;

namespace MarsRover.Src
{
    public class Rover
    {
        private readonly Position _position = new Position();

        public Rover(string position)
        {
            _position.Parse(position);
        }

        public string Execute(string instructions)
        {
            var commands = CommandParser.Parse(instructions);
            foreach (var command in commands)
            {
                command.ApplyTo(_position);
            }
            return _position.ToString();
        }
    }

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
            }
        }

        public override string ToString() => $"{Xaxis} {Yaxis} {CardinalPosition}";
    }

    public class RoverCommands : List<RoverCommand>
    {
    }
}