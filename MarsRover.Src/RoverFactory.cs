namespace MarsRover.Src
{
    public class RoverFactory
    {
        public static Rover New(Plateau plateau, UIPrinter uiPrinter)
        {
            var initialPosition = uiPrinter.ReadLine("Please, enter the Rover's initial position coordinates: ");
            return new Rover(initialPosition);
        }
    }
}
