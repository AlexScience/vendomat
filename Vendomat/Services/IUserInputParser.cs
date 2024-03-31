using Vendomat.Models;

namespace Vendomat.Services;

public interface IUserInputParser
{
    UserScenario GetUserScenario(string input);
}