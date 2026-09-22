using CommandPattern.Devices;

namespace CommandPattern.Commands;

public sealed class TVOffCommand(TV tv) : ICommand
{
    public void Execute() => tv.TurnOff();

    public void Undo() => tv.TurnOn();
}
