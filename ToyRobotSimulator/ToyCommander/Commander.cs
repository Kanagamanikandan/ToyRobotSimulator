using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.ToyRobot;
using ToyRobotSimulator.Table;

namespace ToyRobotSimulator.ToyCommander
{
    public class Commander
    {
        public ITable Table { get; private set; }
        public Robot Robot { get; private set; }

        public Commander(ITable table,Robot robot)
        {
            this.Table = table;
            this.Robot = robot;
        }

        public string ExecuteCommand(string commandText)
        {

            return string.Empty;
        }


    }
}
