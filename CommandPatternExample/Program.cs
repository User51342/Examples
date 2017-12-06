using System;
using System.Collections.Generic;
using System.Linq;
using CommandPatternExample.Interfaces;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new CommandParser();
            var commands = parser.GetCommands();
            if (args.Length == 0)
            {
               DisplayCommandDescriptions(commands);
                return;
            }

            var command = parser.GetCommand(args);
            command.Execute();
        }

        private static void DisplayCommandDescriptions(IEnumerable<ICommandFactory> commands)
        {
            Console.WriteLine("Available commands:");
            foreach (var c in commands)
            {
                Console.WriteLine($"- {c.Usage}");
            }
        }
    }
}
