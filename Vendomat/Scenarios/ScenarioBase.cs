namespace Vendomat.Scenarios;

public class ScenarioBase
{
    private IEnumerable<IScenarioStep> _steps;

    public ScenarioBase(IEnumerable<IScenarioStep> steps)
    {
        _steps = steps;
    }

    public void Run<T>(IScenarioContext<T> context)
    {
        foreach (var step in _steps)
        {
            step.Run();
        }
    }
}