using System.Text.RegularExpressions;
using Vendomat.Models;

namespace Vendomat.Services;

public class UserInputParser : IUserInputParser
{
    private readonly Regex _selectItemRegex = new(Commands.Select);
    private readonly Regex _addCoinRegex = new(Commands.AddCoin);
    private readonly Regex _addBanknoteRegex = new(Commands.AddBanknote);

    public UserScenario GetUserScenario(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("Пустая строка не является допустимым сценарием.");
        }

        if (_selectItemRegex.IsMatch(input))
        {
            return UserScenario.SelectItem;
        }
        else if (_addCoinRegex.IsMatch(input))
        {
            return UserScenario.AddCoin;
        }
        else if (_addBanknoteRegex.IsMatch(input))
        {
            return UserScenario.AddBanknote;
        }
        else if (_addBanknoteRegex.IsMatch(input))
        {
            return UserScenario.Change;
        }
        else
        {
            throw new InvalidOperationException("Неизвестный сценарий");
        }
    }
}