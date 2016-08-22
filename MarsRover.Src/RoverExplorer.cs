namespace MarsRover.Src
{
    public class RoverExplorer
    {
        public static void Handle(Rover rover,UIPrinter uiPrinter)
        {
            var instructions = uiPrinter.ReadLine("Please, enter the series of exploration instructions: ");
            var newPosition = rover.Execute(instructions);
            uiPrinter.WriteLine(newPosition);
        }
    }
}