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
        private Plateau _plateau;
        private Rover _rover;
        private UIPrinter _console;

        [SetUp]
        public void SetUp()
        {
            _console = Substitute.For<UIPrinter>();
            _plateau = Substitute.For<Plateau>(_console);
        }

        [Test]
        public void Feature1()
        {
            _rover = RoverFactory.New(_plateau, _console);
            var rover = _rover;
            _instructions = "LMLMLMLMM";
            
            _console.ReadLine("").Returns("5 5", "1 2 N",_instructions);

            rover.Execute(_instructions);

            Received.InOrder(() =>
            {
                _console.ReadLine("Please, enter the Upper-Right coordinates of the plateau: ");
                _console.ReadLine("Please, enter the Rover's initial position coordinates: ");
                _console.ReadLine("Please, enter the series of exploration instructions: ");
                _console.WriteLine("1 3 N");
            });
        }
    }
}
