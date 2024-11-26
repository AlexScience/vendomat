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
            
                // Создание контекста для сценария SelectItemScenario
                var context = new SelectItemScenarioContext();
            
                // Передача контекста в метод Run
                new SelectItemScenario(steps).Run(context);
                break;
            
            case UserScenario.SelectItem:
                Console.WriteLine("Выбран товар.");
                break;
            
            case UserScenario.AddCoin:
                Console.WriteLine("Добавлена монета.");
                break;
            
            case UserScenario.AddBanknote:
                Console.WriteLine("Добавлена банкнота.");
                break;
            
            default:
                throw new InvalidOperationException("Неизвестный сценарий");
        }
    }
}