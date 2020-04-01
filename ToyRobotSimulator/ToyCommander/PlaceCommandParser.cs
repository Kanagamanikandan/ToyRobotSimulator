using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.ToyRobot;

namespace ToyRobotSimulator.ToyCommander
{
    class PlaceCommandParser
    {
        public PlaceCommand ParsePlaceCommand(string commandText)
        {
            string[] commandParams = commandText.Split(new char[] { ' ', ',' });

            int x = int.Parse(commandParams[1]);
            int y = int.Parse(commandParams[2]);
            Position position = new Position(x, y);

            Direction direction;
            if (!Enum.TryParse<Direction>(commandParams[3], true, out direction))
                throw new ArgumentException("Invalid direction.");

            return new PlaceCommand(position, direction);

        }
    }
}
