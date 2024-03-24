using System.Text.RegularExpressions;
using Vendomat.Models;

var balance = new ClientBalance();
var storage = new ProductItemsStorage();

var selectItemRegex = new Regex(Commands.Select);
var addCoinRegex = new Regex(Commands.AddCoin);
var addBanknoteRegex = new Regex(Commands.AddBanknote);

Console.WriteLine("Выберите продукт или пополните баланс счёта:");

var exitCommand = "exit";
while (true)
{
    var input = Console.ReadLine() ?? string.Empty;
    if (input == exitCommand)
    {
        Console.WriteLine("Завершение работы автомата...");
        break;
    }
    
    if (selectItemRegex.IsMatch(input))
    {
        ProcessItemSelection(input);
    }
    else if (addCoinRegex.IsMatch(input))
    {
        ProcessBalanceReplenish(input, BalanceReplenishType.Coin);
    }
    else if (addBanknoteRegex.IsMatch(input))
    {
        ProcessBalanceReplenish(input, BalanceReplenishType.Banknote);
    }
    else
    {
        throw new InvalidOperationException("Unknown command");
    }
}

void ProcessItemSelection(string command)
{
    Console.WriteLine($"Selecting item {command}...");
    var commandParts = command.Split(" ", StringSplitOptions.TrimEntries);
    
    var slot = ItemSlot.FromRawString(commandParts[1]);
    var productItemInfo = storage.GetItemInfo(slot);

    if (productItemInfo == null)
    {
        Console.WriteLine("Slot not found. Please, select other slot!");
        return;
    }
    
    if (productItemInfo.AvailableCount <= 0)
    {
        Console.WriteLine("Not enough product items. Please, select other product!");
        return;
    }

    var withdrawalSum = productItemInfo.Product.Price;
    if (!balance.IsEnoughMoney(withdrawalSum))
    {
        Console.WriteLine("Not enough money!");
        return;
    }
    
    Console.WriteLine("Processing payment...");
    balance.Withdraw(withdrawalSum);

    var product = storage.GetItem(slot);
    Console.WriteLine($"Successfully got {product.Name} with price {product.Price}." +
                      $" {productItemInfo.AvailableCount} is still available");
}

void ProcessBalanceReplenish(string command, BalanceReplenishType replenishType)
{
    Console.WriteLine($"Replenishing balance with command {command}...");

    var commandParts = command.Split(":", StringSplitOptions.TrimEntries);
    var replenishSum = int.Parse(commandParts[1]);
    balance.Replenish(replenishSum);
}