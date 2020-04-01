using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulator.ToyRobot
{
    public class Robot
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public void Place(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }
        public Position GetNewPosition()
        {
            var newPosition = new Position(Position.X, Position.Y);
            switch (Direction)
            {
                case Direction.North:
                    newPosition.Y++;
                    break;
                case Direction.East:
                    newPosition.X++;
                    break;
                case Direction.South:
                    newPosition.Y--;
                    break;
                case Direction.West:
                    newPosition.X--;
                    break;
            }
            return newPosition;
        }

        public void RotateLeft()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.West;
                    break;
                case Direction.East:
                    Direction = Direction.North;
                    break;
                case Direction.South:
                    Direction = Direction.East;
                    break;
                case Direction.West:
                    Direction = Direction.South;
                    break;
            }
        }

        public void RotateRight()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.East;
                    break;
                case Direction.East:
                    Direction = Direction.South;
                    break;
                case Direction.South:
                    Direction = Direction.West;
                    break;
                case Direction.West:
                    Direction = Direction.North;
                    break;
            }
        }

        public string Report()
        {
            return $"Output: {Position.X},{Position.Y},{Direction.ToString().ToUpper()}";
        }
    }
}
