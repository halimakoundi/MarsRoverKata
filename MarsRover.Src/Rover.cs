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
            commands.ForEach(c => c.ApplyTo(_position));
            return _position.ToString();
        }
    }
}