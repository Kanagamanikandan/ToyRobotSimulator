using NUnit.Framework;
using ToyRobotSimulator.ToyCommander;
using ToyRobotSimulator.Table;
using ToyRobotSimulator.ToyRobot;

namespace ToyRobotSimulator.Test
{
    [TestFixture]
    public class TestCommander
    {
        [Test]
        public void TestValidCommandPlace()
        {
            //arrange
            ITable table = new SquareTable(5);
            Robot robot = new Robot();
            Commander commander = new Commander(table, robot);

            //act
            commander.ExecuteCommand("PLACE 2,4,SOUTH");

            //assert
            Assert.AreEqual(2, robot.Position.X);
            Assert.AreEqual(4, robot.Position.Y);
            Assert.AreEqual(Direction.South, robot.Direction);
        }

        [Test]
        public void TestInvalidCommandPlace()
        {
            //arrange
            ITable table = new SquareTable(5);
            Robot robot = new Robot();
            Commander commander = new Commander(table, robot);

            //act
            commander.ExecuteCommand("PLACE 6,4,SOUTH");

            //assert
            Assert.IsNull(robot.Position);
        }

        [Test]
        public void TestValidCommandMove()
        {
            //arrange
            ITable table = new SquareTable(5);
            Robot robot = new Robot();
            Commander commander = new Commander(table, robot);

            //act
            commander.ExecuteCommand("PLACE 2,4,SOUTH");
            commander.ExecuteCommand("MOVE");

            //assert
            Assert.AreEqual(2, robot.Position.X);
            Assert.AreEqual(3, robot.Position.Y);
            Assert.AreEqual(Direction.South, robot.Direction);
        }

        [Test]
        public void TestInvalidCommandMove()
        {
            //arrange
            ITable table = new SquareTable(5);
            Robot robot = new Robot();
            Commander commander = new Commander(table, robot);

            //act
            commander.ExecuteCommand("PLACE 2,4,NORTH");
            commander.ExecuteCommand("MOVE");
            //should be ignored as invalid position
            commander.ExecuteCommand("MOVE");

            //assert
            Assert.AreEqual(2, robot.Position.X);
            Assert.AreEqual(5, robot.Position.Y);
            Assert.AreEqual(Direction.North, robot.Direction);
        }
    }
}
