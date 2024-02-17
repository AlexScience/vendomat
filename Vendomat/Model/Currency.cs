namespace Vendomat.Model;

public abstract class Currency
{
    public int Nominal { get; }
    public abstract CurrencyType Type { get; }


    public Currency(int nominal)
    {
        Nominal = nominal;
    }

    public enum CurrencyType
    {
        Coin = 0,
        Banknote = 1
    }

    public override string ToString()
    {
        return $"Currency type: {Type} | Nominal: {Nominal}";
    }
}