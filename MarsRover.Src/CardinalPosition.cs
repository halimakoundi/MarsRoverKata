using System;

namespace MarsRover.Src
{
    public class CardinalPosition
    {
        private Cardinality _cardinality;

        public CardinalPosition(string value)
        {
            _cardinality = GetCardinalityFromDescription(value);
        }

        public void Left()
        {
            if ((int)_cardinality > 0)
            {
                _cardinality -= 1;
            }
            else
            {
                _cardinality = Cardinality.W;
            }
        }

        public void Right()
        {
            if ((int)_cardinality < 3)
            {
                _cardinality += 1;
            }
            else
            {
                _cardinality = 0;
            }
        }

        public override string ToString()
        {
            return $"{GetValue()}";
        }

        public Cardinality GetValue() => _cardinality;

        private static Cardinality GetCardinalityFromDescription(string description)
        {
            return (Cardinality)Enum.Parse(typeof(Cardinality), description);
        }
    }
}