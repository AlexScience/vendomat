using Vendomat.Models;

namespace Vendomat.Services;

public interface IScenarioRunner
{
    void RunScenario(UserScenario scenario);
}