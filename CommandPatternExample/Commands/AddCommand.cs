using System;
using CommandPatternExample.Interfaces;

namespace CommandPatternExample.Commands
{
   public class AddCommand : ICommand, ICommandFactory
    {
        #region properties

        public int Value { get; set; }
        #endregion

        #region ICommand implementation
        public void Execute()
        {
           Console.Write($"Added {Value}");
        }
        #endregion

        #region ICommandFactory implementation

        public string CommandName => "Add";
        public string Usage => "Add value";
        public ICommand MakeComand(string[] arguments)
        {
            var newValue = arguments.Length < 2 ? 0 : int.Parse(arguments[1]);
            return new AddCommand() { Value = newValue };
        }
        #endregion
    }
}
