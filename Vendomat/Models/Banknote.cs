namespace Vendomat.Models;

public class Banknote : Currency
{
    public override CurrencyType Type => CurrencyType.Banknote;

    public Banknote(int nominal) : base(nominal)
    {
    }
}