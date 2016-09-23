namespace MarsRover.Src.Rover_Elements
{
    public class RoverFactory
    {
        public static Rover New(UIPrinter uiPrinter)
        {
            var initialPosition = uiPrinter.ReadLine("Please, enter the Rover's initial position coordinates: ");
            return new Rover(initialPosition);
        }
    }
}
