using NUnit.Framework;
using ToyRobotSimulator.Table;
using ToyRobotSimulator.ToyRobot;

namespace ToyRobotSimulator.Test
{
    [TestFixture]
    public class TestTable
    {
        [Test]
        public void TestValidPosition()
        {
            //arrange
            SquareTable table = new SquareTable(5);

            //act
            Position position = new Position(5, 5);
            bool isValidPosition = table.IsValidPosition(position);

            //assert
            Assert.IsTrue(isValidPosition);
        }

        [Test]
        public void TestInvalidPosition()
        {
            //arrange
            SquareTable table = new SquareTable(5);

            //act
            Position position = new Position(5, 6);
            bool isValidPosition = table.IsValidPosition(position);

            //assert
            Assert.IsFalse(isValidPosition);
        }
    }
}
