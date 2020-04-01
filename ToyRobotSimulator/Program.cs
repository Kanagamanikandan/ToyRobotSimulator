using System;
using ToyRobotSimulator.Table;
using ToyRobotSimulator.ToyCommander;
using ToyRobotSimulator.ToyRobot;

namespace ToyRobotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            ITable table = new SquareTable(5);
            Robot robot = new Robot();
            Commander commander = new Commander(table, robot);

            do
            {
                string command = Console.ReadLine();

                if (command == "EXIT")
                    break;

                var output = commander.ExecuteCommand(command);

                if (!string.IsNullOrEmpty(output))
                    Console.WriteLine(output);
            } while (true);
        }
    }
}
