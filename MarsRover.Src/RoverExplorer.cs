namespace MarsRover.Src
{
    public class RoverExplorer
    {
        public static void Handle(Rover rover,UIPrinter uiPrinter, RoverCommands commands)
        {
            var newPosition = rover.Execute(commands);
            uiPrinter.WriteLine(newPosition);
        }
    }
}