using MarsRover.Src;
using NSubstitute;
using NSubstitute.Exceptions;
using NUnit.Framework;

namespace MarsRover.Tests
{
    [TestFixture]
    class RoverShould
    {
        private UIPrinter _console;
        private Plateau _plateau;

        [SetUp]
        public void SetUp()
        {
            _console = Substitute.For<UIPrinter>(); ;
            _plateau = Substitute.For<Plateau>(_console);
        }

        [Test]
        public void move_up_once_for_command_M_and_starts_00N()
        {
            var instructions    = "M";
            _console.ReadLine("Please, enter the Rover's initial position coordinates: ").Returns("0 0 N");

            var rover = RoverFactory.New(_plateau, _console);

            var position    = rover.Execute(instructions);
            Assert.That(position, Is.EqualTo("0 1 N"));
        }

        [Test]
        public void move_east_once_for_command_M_and_starts_00E()
        {
            var instructions = "M";
            _console.ReadLine("Please, enter the Rover's initial position coordinates: ")
                .Returns("0 0 E");

            var rover = RoverFactory.New(_plateau, _console);

            var position = rover.Execute(instructions);
            Assert.That(position, Is.EqualTo("1 0 E"));
        }
    }
}
