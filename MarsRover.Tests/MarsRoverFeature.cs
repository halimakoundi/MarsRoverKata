using MarsRover.Src;
using NSubstitute;
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
        private string _newPosition;
        private string _initialPosition;
        private string _plateauUpperRight;
        private CommandParser _parser;

        [SetUp]
        public void SetUp()
        {
            _console = Substitute.For<UIPrinter>();
            _plateau = Substitute.For<Plateau>(_console);
            _parser = new CommandParser();
        }

        [Test]
        public void Feature1()
        {
            _instructions = "LMLMLMLMM";
            _plateauUpperRight = "5 5";
            _initialPosition = "1 2 N";
            _newPosition = "1 3 N";

            _console.ReadLine("Please, enter the Upper-Right coordinates of the plateau: ")
                .Returns(_plateauUpperRight);
            _console.ReadLine("Please, enter the Rover's initial position coordinates: ")
                    .Returns(_initialPosition);
            _console.ReadLine("Please, enter the series of exploration instructions: ")
                    .Returns(_instructions);

            _rover = RoverFactory.New(_console);
            var instructions = _console.ReadLine("Please, enter the series of exploration instructions: ");

            var roverControlSystem  = new RoverControlSystem(_rover, _console,_parser);
            roverControlSystem.Handle( instructions);

            Received.InOrder(() =>
            {
                _console.ReadLine("Please, enter the Upper-Right coordinates of the plateau: ");
                _console.ReadLine("Please, enter the Rover's initial position coordinates: ");
                _console.ReadLine("Please, enter the series of exploration instructions: ");
                _console.WriteLine(_newPosition);
            });
        }
    }
}
