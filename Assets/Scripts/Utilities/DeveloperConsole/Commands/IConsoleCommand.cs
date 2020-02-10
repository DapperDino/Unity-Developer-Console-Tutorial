namespace DapperDino.UDCT.Utilities.DeveloperConsole.Commands
{
    public interface IConsoleCommand
    {
        string CommandWord { get; }
        bool Process(string[] args);
    }
}
