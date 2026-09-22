using CommandPattern.Devices;

namespace CommandPattern.Commands;

public sealed class TVOnCommand(TV tv) : ICommand
{
    public void Execute() => tv.TurnOn();

    public void Undo() => tv.TurnOff();
}
