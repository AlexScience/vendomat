namespace Vendomat.Scenarios;

public abstract class ScenarioStep : IScenarioStep
{
    public abstract string Name { get; }

    public void Run()
    {
        Console.WriteLine($"{Name} has started");
    }
}