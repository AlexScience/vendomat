using Vendomat.Services;

namespace Vendomat.Models;

public sealed class Vendomat
{
    private readonly IEnumerable<Product> _products;
    private readonly Bank _bank;
    private static readonly IUserInputParser _inputParser = new UserInputParser();

    public Vendomat(IEnumerable<Product> products, Bank bank)
    {
        _products = products ?? throw new ArgumentNullException(nameof(products));
        _bank = bank ?? throw new ArgumentNullException(nameof(bank));
    }

    public static void Run()
    {
        var exitCommand = "exit";
        while (true)
        {
            Console.WriteLine("Выберите товар или пополните счет");
            var input = Console.ReadLine() ?? string.Empty;
            
            if (input.Equals(exitCommand, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Завершение работы автомата...");
                break;
            }

            UserScenario scenario;
            try
            {
                scenario = _inputParser.GetUserScenario(input);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            switch (scenario)
            {
                case UserScenario.SelectItem:
                    Console.WriteLine("Товар выбран.");
                    break;
                case UserScenario.AddCoin:
                    Console.WriteLine("Монета добавлена.");
                    break;
                case UserScenario.AddBanknote:
                    Console.WriteLine("Банкнота добавлена.");
                    break;
                case UserScenario.Change:
                    Console.WriteLine("Сдача выдана.");
                    break;
                default:
                    throw new InvalidOperationException("Неизвестный сценарий");
            }
        }
    }
}