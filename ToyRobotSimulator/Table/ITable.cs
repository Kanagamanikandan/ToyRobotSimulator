using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.ToyRobot;

namespace ToyRobotSimulator.Table
{
    public interface ITable
    {
        bool IsValidPosition(Position position);
    }
}
