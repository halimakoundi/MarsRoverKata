namespace MarsRover.Src
{
    public class Coordinates
    {
        private int _yaxis;
        private int _xaxis;

        public Coordinates(int xaxis, int yaxis)
        {
            _xaxis = xaxis;
            _yaxis = yaxis;
        }
        
        public void MoveUp()
        {
            _yaxis += 1;
        }

        public void MoveBackward()
        {
            _xaxis -= 1;
        }

        public void MoveForward()
        {
            _xaxis += 1;
        }

        public void MoveDown()
        {
            _yaxis -= 1;
        }

        public string Display()
        {
            return $"{_xaxis} {_yaxis}";
        }
    }
}