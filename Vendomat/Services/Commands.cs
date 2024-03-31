namespace Vendomat.Services;

public static class Commands
{
    public static string Select => "item [A-Z]:[0-99]";
    public static string AddCoin => "coin: [1|2|5|10]";
    public static string AddBanknote => "banknote: [50|100|500]";
}