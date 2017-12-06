using System;
using CommandPatternExample.Interfaces;

namespace CommandPatternExample.Commands
{
    public class NotFoundCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Command not Found");
        }

        public string CommandName => "NotFound";
        public string Usage => "Cant find this command.";
        public ICommand MakeComand(string[] arguments)
        {
            return new NotFoundCommand();
        }
    }
}
