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
            Command command;
            if (!Enum.TryParse(commandText.Split(' ')[0], true, out command))
                return "Invalid Command! Please try again.";

            if (Robot.Position == null && command != Command.Place)
                return string.Empty;

            switch (command)
            {
                case Command.Place:
                    try
                    {
                        PlaceCommandParser parser = new PlaceCommandParser();
                        PlaceCommand placeCommand = parser.ParsePlaceCommand(commandText);
                        if (Table.IsValidPosition(placeCommand.Position))
                            Robot.Place(placeCommand.Position, placeCommand.Direction);
                    }
                    catch (ArgumentException ex)
                    {
                        return ex.Message;
                    }
                    break;
                case Command.Move:
                    var newPosition = Robot.GetNewPosition();
                    if (Table.IsValidPosition(newPosition))
                        Robot.Position = newPosition;
                    break;
                case Command.Left:
                    Robot.RotateLeft();
                    break;
                case Command.Right:
                    Robot.RotateRight();
                    break;
                case Command.Report:
                    return Robot.Report();
            }
            return string.Empty;
        }


    }
}
