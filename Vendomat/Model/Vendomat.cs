namespace Vendomat.Model;

public class Vendomat
{
    private readonly IEnumerable<Product> _products;
    public readonly Bank _bank;

    public Vendomat(IEnumerable<Product> products, IEnumerable<Currency> currencies)
    {
        _products = products;
        _bank = new Bank();
    }

    public Vendomat()
    {
        
    }

    public void DepositCoins(Coin coin)
    {
        _bank.Deposit(coin);
    }

    public void DepositBanknotes(Banknote banknote)
    {
        _bank.Deposit(banknote);
    }

    public void DepositCoins(IEnumerable<Coin> coins)
    {
        foreach (var coin in coins)
        {
            DepositCoins(coin);
        }
    }

    public void DepositBanknotes(IEnumerable<Banknote> banknotes)
    {
        foreach (var banknote in banknotes)
        {
            DepositBanknotes(banknote);
        }
    }
}