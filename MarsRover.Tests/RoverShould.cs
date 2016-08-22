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

        [TestCase("0 0 N", "0 1 N", "M")]
        [TestCase("0 0 E", "1 0 E", "M")]
        [TestCase("0 0 W", "-1 0 W", "M")]
        [TestCase("0 0 S", "0 -1 S", "M")]
        public void move_to_right_position_for_given_command_given_initial_position
                    (string initialPosition, string expected, string instructions)
        {
            _console.ReadLine("Please, enter the Rover's initial position coordinates: ")
                .Returns(initialPosition);

            var rover = RoverFactory.New(_plateau, _console);

            var position = rover.Execute(instructions);
            Assert.That(position, Is.EqualTo(expected));
        }

        [TestCase("0 0 N", "0 0 W", "L")]
        [TestCase("0 0 E", "0 0 N", "L")]
        [TestCase("0 0 W", "0 0 S", "L")]
        [TestCase("0 0 S", "0 0 E", "L")]
        public void face_the_right_direction_for_given_command_given_initial_facing
                    (string initialPosition, string expected, string instructions)
        {
            _console.ReadLine("Please, enter the Rover's initial position coordinates: ")
                .Returns(initialPosition);

            var rover = RoverFactory.New(_plateau, _console);

            var position = rover.Execute(instructions);
            Assert.That(position, Is.EqualTo(expected));
        }

        [TestCase("0 0 N", "0 0 E", "R")]
        [TestCase("0 0 E", "0 0 S", "R")]
        [TestCase("0 0 S", "0 0 W", "R")]
        [TestCase("0 0 W", "0 0 N", "R")]
        public void face_the_right_direction_for_given_right_command_given_initial_facing
                    (string initialPosition, string expected, string instructions)
        {
            _console.ReadLine("Please, enter the Rover's initial position coordinates: ")
                .Returns(initialPosition);

            var rover = RoverFactory.New(_plateau, _console);

            var position = rover.Execute(instructions);
            Assert.That(position, Is.EqualTo(expected));
        }
    }
}
