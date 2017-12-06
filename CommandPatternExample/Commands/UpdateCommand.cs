using System;
using CommandPatternExample.Interfaces;

namespace CommandPatternExample.Commands
{
    public class UpdateCommand : ICommand, ICommandFactory
    {
        public int NewValue { get; set; }
        public void Execute()
        {
            Console.WriteLine($"Update the value to {NewValue}.");
        }

        public string CommandName => "Update";

        public string Usage => "Update Value";

        public ICommand MakeComand(string[] arguments)
        {
            var newValue = arguments.Length < 2 ? 0 : int.Parse(arguments[1]);
            return new UpdateCommand() { NewValue = newValue };
        }
    }
}
