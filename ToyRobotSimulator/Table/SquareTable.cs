using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.ToyRobot;

namespace ToyRobotSimulator.Table
{
    public class SquareTable : ITable
    {
        public int XLength { get; set; }
        public int YLength { get; set; }
        public SquareTable(int length)
        {
            this.XLength = length;
            this.YLength = length;
        }
        public bool IsValidPosition(Position position)
        {
            return position.X <= XLength && position.X >= 0
                && position.Y <= YLength && position.Y >= 0;
        }
    }
}
