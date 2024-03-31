using Vendomat.Models;
using Vendomat.Scenarios;
using Vendomat.Scenarios.SelectItem;

namespace Vendomat.Services;

public class ScenarioRunner : IScenarioRunner
{
    public void RunScenario(UserScenario scenario)
    {
        switch (scenario)
        {
            case UserScenario.Change:
                var steps = new IScenarioStep[]
                {
                    new CheckProductAvailabilityStep(),
                    new CheckBalanceStep(),
                };
                new SelectItemScenario(steps).Run(new );
                
                break;
            case UserScenario.SelectItem:
                break;
            case UserScenario.AddCoin:
                break;
            case UserScenario.AddBanknote:
                break;
            default:
                throw new InvalidOperationException("Неизвестный сценарий");
        }
    }
}