using CommandPattern.Commands;
using CommandPattern.Devices;
using CommandPattern.Invoker;

namespace CommandPattern;

internal static class Program
{
    private static void Main()
    {
        var remote = new RemoteControl();
        var tv = new TV();
        var stereo = new Stereo();

        ICommand[] commands =
        [
            new TVOnCommand(tv),
            new StereoOnCommand(stereo),
            new TVOffCommand(tv),
            new TurnOffStereoCommand(stereo),
        ];

        foreach (var command in commands)
        {
            remote.SetCommand(command);
            remote.PressButton();
        }
    }
}
