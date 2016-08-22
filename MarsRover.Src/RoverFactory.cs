namespace MarsRover.Src
{
    public class RoverFactory
    {
        public static Rover New(Plateau plateau, UIPrinter uiPrinter)
        {
            var initialPosition = uiPrinter.ReadLine("Please, enter the Rover's initial position coordinates: ");
            var rover = new Rover(initialPosition);
            RoverExplorer.Handle(rover, uiPrinter);
            return rover;
        }
    }

    public class RoverExplorer
    {
        public static void Handle(Rover rover,UIPrinter uiPrinter)
        {
            uiPrinter.ReadLine("Please, enter the series of exploration instructions: ");
        }
    }
}
