using System.ComponentModel;

namespace MarsRover.Src
{
    public enum Cardinalities
    {
        [Description("North")]
        N = 0,
        [Description("Eeast")]
        E = 1,
        [Description("South")]
        S = 2,
        [Description("West")]
        W = 3
    }
}