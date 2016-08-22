namespace MarsRover.Src
{
    public class Cardinality
    {
        private string _value;

        public Cardinality(string value)
        {
            _value = value;
        }

        public void Left()
        {
            switch (_value)
            {
                case "N":
                    _value = "W";
                    break;
                case "E":
                    _value = "N";
                    break;
                case "W":
                    _value = "S";
                    break;
                case "S":
                    _value = "E";
                    break;
            }
        }

        public override string ToString()
        {
            return $"{_value}";
        }

        public void Right()
        {
            switch (_value)
            {
                case "N":
                    _value = "E";
                    break;
                case "E":
                    _value = "S";
                    break;
                case "S":
                    _value = "W";
                    break;
                case "W":
                    _value = "N";
                    break;
            }
        }

        public string GetValue() => _value;
    }
}