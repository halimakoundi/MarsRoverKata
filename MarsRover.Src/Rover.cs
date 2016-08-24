namespace MarsRover.Src
{
    public class Rover
    {
        private readonly Position _position = new Position();

        public Rover(string position)
        {
            _position.Parse(position);
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