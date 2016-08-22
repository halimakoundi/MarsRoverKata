using MarsRover.Src;
using NSubstitute;
using NSubstitute.Core.Arguments;
using NUnit.Framework;

namespace MarsRover.Tests
{
    [TestFixture]
    public class MarsRoverFeature
    {
        private string _instructions;

        [Test]
        public void doSomething()
        {
            var console = Substitute.For<UIPrinter>();

            var rover = RoverFactory.New(console);
            _instructions = "LMLMLMLMM";

            console.ReadLine("").Returns("5 5", "1 2 N",_instructions);

            rover.Execute(_instructions);

            Received.InOrder(() =>
            {
                console.ReadLine("Please, enter the Upper-Right coordinates of the plateau: ");
                console.ReadLine("Please, enter the Rover's initial position coordinates: ");
                console.ReadLine("Please, enter the series of exploration instructions: ");
                console.WriteLine("1 3 N");
            });
        }
    }
}
