using CommandPattern.Devices;

namespace CommandPattern.Commands;

public sealed class TurnOffStereoCommand(Stereo stereo) : ICommand
{
    public void Execute() => stereo.TurnOff();

    public void Undo()
    {
        stereo.TurnOn();
    }
}
