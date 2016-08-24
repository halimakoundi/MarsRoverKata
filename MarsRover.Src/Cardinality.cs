using System;
using System.ComponentModel;
using System.Reflection;

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
                _cardinalities = Cardinalities.West;
            }
        }

        public override string ToString()
        {
            return $"{Cardinality.GetEnumDescription(_cardinalities)}";
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

        public string GetValue() => GetEnumDescription(_cardinalities);

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        private Cardinalities GetCardinalityFromDescription(string description)
        {
            if (description == "N")
            {
                return Cardinalities.North;
            }
            else if (description == "E")
            {
                return Cardinalities.East;
            }
            else if (description == "W")
            {
                return Cardinalities.West;
            }
            else
            {
                return Cardinalities.South;
            }
        }
    }
}