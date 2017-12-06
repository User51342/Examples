using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CommandPatternExample.Commands;
using CommandPatternExample.Interfaces;

namespace CommandPatternExample
{
    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> _commands;

        public CommandParser()
        {
            _commands = GetAvailableCommands();
        }

        public IEnumerable<ICommandFactory> GetCommands()
        {
            return _commands;
        }

        public ICommand GetCommand(string[] args)
        {
            var command = _commands.FirstOrDefault(c => c.CommandName == args[0]);
            if (command != null)
            {
                return command.MakeComand(args);
            }
            return new NotFoundCommand();
        }

        private IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            var commands = new List<ICommandFactory>();
            var searchInterfaceType = typeof(ICommand);
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => searchInterfaceType.IsAssignableFrom(t) && t.Name != "NotFoundCommand");
            foreach (var type in types.Where(t => !t.IsInterface))
            {
                commands.Add(Activator.CreateInstance(type) as ICommandFactory);
            }
            return commands;
        }
    }
}
