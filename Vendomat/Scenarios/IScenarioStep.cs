namespace Vendomat.Scenarios;

public interface IScenarioStep
{
    public string Name { get; }
    public void Run();
}