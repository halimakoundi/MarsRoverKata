namespace MarsRover.Src
{
    public class Rover
    {
        private readonly Position _position;

        public Rover(string position)
        {
            _position = new Position(position);
        }

        public string Execute(RoverCommands commands)
        {
            foreach (var command in commands)
            {
                command.ApplyTo(_position);
            }
            return _position.ToString();
        }
    }
}