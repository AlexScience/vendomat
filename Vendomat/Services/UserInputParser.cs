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
        UserScenario scenario;
        
        if (_selectItemRegex.IsMatch(input))
        {
            scenario = UserScenario.SelectItem;
        }
        else if (_addCoinRegex.IsMatch(input))
        {
            scenario = UserScenario.AddCoin;
        }
        else if (_addBanknoteRegex.IsMatch(input))
        {
            scenario = UserScenario.AddBanknote;
        }
        else
        {
            throw new InvalidOperationException("Неизвестный сценарий");
        }

        return scenario;
    }
}