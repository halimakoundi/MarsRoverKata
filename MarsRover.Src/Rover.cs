namespace MarsRover.Src
{
    public class Rover
    {
        private IPosition _currentState;
        private Coordinates _coords;

        public Rover(string position)
        {
            var positions = Parse(position);
            SetAxis(positions);
            SetInitialCardinalPosition(positions);
        }

        public string Execute(RoverCommands commands)
        {
            commands.ExecuteCommands(this);
            return ToString();
        }

        private void SetInitialCardinalPosition(string[] positions)
        {
            switch (positions[2])
            {
                case "N":
                    _currentState = new FacingNorth(_coords);
                    break;
                case "E":
                    _currentState = new FacingEast(_coords);
                    break;
                case "W":
                    _currentState = new FacingWest(_coords);
                    break;
                case "S":
                    _currentState = new FacingSouth(_coords);
                    break;
            }
        }

        private void SetAxis(string[] positions)
        {
            _coords = new Coordinates(int.Parse(positions[0]), int.Parse(positions[1]));
        }

        private static string[] Parse(string position)
        {
            var positions = position.Split(' ');
            return positions;
        }

        public void Move()
        {
            _currentState.Move();
        }

        public void TurnLeft()
        {
            _currentState = _currentState.TurnLeft();
        }

        public void TurnRight()
        {
            _currentState = _currentState.TurnRight();
        }

        public override string ToString() => $"{_currentState.Coords.Display()} {_currentState.CardinalPosition}";
    }
}