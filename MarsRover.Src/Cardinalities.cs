using System.ComponentModel;

namespace MarsRover.Src
{
    public enum Cardinalities
    {
        [Description("N")]
        North = 0,
        [Description("E")]
        East = 1,
        [Description("S")]
        South = 2,
        [Description("W")]
        West = 3
    }
}