# C# Design Patterns

Two focused .NET 8 console examples that demonstrate common object-oriented design patterns through small, runnable scenarios.

> **Kısa Türkçe özet:** Command ve Builder tasarım desenlerini çalışan C# konsol örnekleriyle gösteren mini proje koleksiyonu.

## Examples

### Command Pattern: Remote Control

`command-pattern-remote-control` decouples a remote-control invoker from TV and stereo receiver objects. Each action is encapsulated in a command object, making actions easy to add, replace, and sequence.

### Builder Pattern: Computer Configurator

`builder-pattern-computer-configurator` guides the construction of a computer configuration from CPU, RAM, and storage input through a builder and director.

## Run

```bash
dotnet run --project command-pattern-remote-control/yazilimmimarisi.csproj
dotnet run --project builder-pattern-computer-configurator/buildpattern.csproj
```

## Verification

Both examples were built with .NET 8 successfully. Build artifacts and local IDE files are excluded from version control.
