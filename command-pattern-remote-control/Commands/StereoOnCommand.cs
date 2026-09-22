using CommandPattern.Devices;

namespace CommandPattern.Commands;

public sealed class StereoOnCommand(Stereo stereo) : ICommand
{
    public void Execute()
    {
        stereo.TurnOn();
    }

    public void Undo() => stereo.TurnOff();
}
