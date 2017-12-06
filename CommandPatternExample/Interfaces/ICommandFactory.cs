namespace CommandPatternExample.Interfaces
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        string Usage { get; }

        ICommand MakeComand(string[] arguments);
    }
}
