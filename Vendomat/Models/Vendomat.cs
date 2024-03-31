using Vendomat.Services;

namespace Vendomat.Models;

public sealed class Vendomat
{
    private readonly IEnumerable<Product> _products;
    public readonly Bank _bank;
    private static readonly IUserInputParser _inputParser = new UserInputParser();
    
    public static void Run()
    {
        var exitCommand = "exit";
        while (true)
        {
            Console.WriteLine("Выберите товар или пополните счет");
            var input = Console.ReadLine() ?? string.Empty;
            if (input == exitCommand)
            {
                Console.WriteLine("Завершение работы автомата...");
                break;
            }

            var scenario = _inputParser.GetUserScenario(input);
            switch (scenario)
            {
                case UserScenario.SelectItem:
                    break;
                case UserScenario.AddCoin:
                    break;
                case UserScenario.AddBanknote:
                    break;
                case UserScenario.Change:
                    break;
                default:
                    throw new InvalidOperationException("Неизвестный сценарий");
            }
        }
    }
}