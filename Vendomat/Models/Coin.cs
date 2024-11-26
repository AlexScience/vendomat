namespace Vendomat.Models;

public class Coin : Currency
{
    public override CurrencyType Type => CurrencyType.Coin;

    public Coin(int nominal) : base(nominal)
    {
    }
}