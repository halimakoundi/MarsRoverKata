using System;

namespace MarsRover.Src
{
    public class Rover
    {
        private readonly string _position;

        public Rover(string position)
        {
            _position = position;
        }

        public string Execute(string instructions)
        {
            throw new NotImplementedException();
        }
    }
}