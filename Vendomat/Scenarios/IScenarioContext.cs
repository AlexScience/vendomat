namespace Vendomat.Scenarios;

public interface IScenarioContext<out T>
{
    T ScenarioData { get; }
}