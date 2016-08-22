namespace MarsRover.Src
{
    public class Plateau
    {
        private string _UpperRight;

        public Plateau(UIPrinter console)
        {
            _UpperRight = console.ReadLine("Please, enter the Upper-Right coordinates of the plateau: ");
        }
    }
}