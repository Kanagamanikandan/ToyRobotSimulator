using NUnit.Framework;
using ToyRobotSimulator.ToyRobot;

namespace ToyRobotSimulator.Test
{
    [TestFixture]
    public class TestRobot
    {
        [Test]
        public void TestValidPlacement()
        {
            //arrange
            Position position = new Position(2, 4);
            Robot robot = new Robot();

            //act
            robot.Place(position, Direction.East);

            //assert
            Assert.AreEqual(2, robot.Position.X);
            Assert.AreEqual(4, robot.Position.Y);
            Assert.AreEqual(Direction.East, robot.Direction);


        }

        [Test]
        public void TestValidMovement()
        {
            //arrage
            Robot robot = new Robot { Position = new Position(2, 3), Direction = Direction.North };

            //act
            Position newPosition = robot.GetNewPosition();

            //assert
            Assert.AreEqual(2, newPosition.X);
            Assert.AreEqual(4, newPosition.Y);
        }

        [Test]
        public void TestValidRotateLeft()
        {
            //arrange
            Robot robot = new Robot { Position = new Position(2, 3), Direction = Direction.North };

            //act
            robot.RotateLeft();

            //assert
            Assert.AreEqual(Direction.West, robot.Direction);
        }

        [Test]
        public void TestValidRotateRight()
        {
            //arrange
            Robot robot = new Robot { Position = new Position(2, 3), Direction = Direction.North };

            //act
            robot.RotateRight();

            //assert
            Assert.AreEqual(Direction.East, robot.Direction);
        }

        [Test]
        public void TestValidReport()
        {
            //arrange
            Robot robot = new Robot { Position = new Position(2, 3), Direction = Direction.North };

            //act
            string output = robot.Report();

            //assert
            Assert.AreEqual($"Output: 2,3,NORTH", output);
        }
    }
}
