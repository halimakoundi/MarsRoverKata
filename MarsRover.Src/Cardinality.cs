using System;

namespace MarsRover.Src
{
    public class Cardinality
    {
        private Cardinalities _cardinalities;

        public Cardinality(string value)
        {
            _cardinalities = GetCardinalityFromDescription(value);
        }

        public void Left()
        {
            if ((int)_cardinalities > 0)
            {
                _cardinalities -= 1;
            }
            else
            {
                _cardinalities = Cardinalities.W;
            }
        }

        public override string ToString()
        {
            return $"{GetValue()}";
        }

        public void Right()
        {
            if ((int)_cardinalities < 3)
            {
                _cardinalities += 1;
            }
            else
            {
                _cardinalities = 0;
            }
        }

        public string GetValue() => _cardinalities.ToString();

        private Cardinalities GetCardinalityFromDescription(string description)
        {
            Cardinalities cardinality;
             Enum.TryParse(description,out cardinality);
            return cardinality;
        }
    }
}