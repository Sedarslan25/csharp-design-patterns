using CommandPattern.Commands;

namespace CommandPattern.Invoker
{
    public class RemoteControl
    {
        private ICommand? _command;

        public void SetCommand(ICommand command) => _command = command;
        public void PressButton() => (_command ?? throw new InvalidOperationException("Önce bir komut atayın.")).Execute();
        public void PressUndo() => (_command ?? throw new InvalidOperationException("Önce bir komut atayın.")).Undo();
    }
}
