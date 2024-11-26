namespace Vendomat.Models;

public abstract class Currency
{
    public int Nominal { get; }
    public abstract CurrencyType Type { get; }


    public Currency(int nominal)
    {
        Nominal = nominal;
    }

    public override string ToString()
    {
        return $"Currency type: {Type} | Nominal: {Nominal}";
    }
}