namespace DesignPatterns.Behavioral.Command
{
    // Invoker
    internal class Switch
    {
        ICommand _closedCommand;
        ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            _closedCommand = closedCommand;
            _openedCommand = openedCommand;
        }

        public void Close()
        {
            _closedCommand.Execute();
        }

        public void Open()
        {
            _openedCommand.Execute();
        }
    }
}
