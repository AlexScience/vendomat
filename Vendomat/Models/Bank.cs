using System.Collections.ObjectModel;
using Vendomat.Models;

namespace Vendomat.Models;

public class Bank
{
    private readonly IList<Coin> _coins;
    private readonly IList<Banknote> _banknotes;
    private int balance;

    
    
    public void Deposit(Currency currency)
    {
        if (currency is Coin coin)
        {
            balance += coin.Nominal;
            _coins.Add(coin);
        }
        else if (currency is Banknote banknote)
        {
            balance += banknote.Nominal;
            _banknotes.Add(banknote);
        }
        else
        {
            Console.WriteLine(new ArgumentNullException(nameof(currency)));
        }
    }

    public int GetCoinBalance()
    {
        return _coins.Sum(coin => coin.Nominal);
    }

    public int GetBanknoteBalance()
    {
        return _banknotes.Sum(banknote => banknote.Nominal);
    }

    public int GetTotalBalance()
    {
        return balance;
    }

    public void RefundPurchase()
    {
        throw new NotImplementedException();
    }

    public void WithdrawCoins()
    {
        throw new NotImplementedException();
    }

    public void WithdrawBancnotes()
    {
        throw new NotImplementedException();
    }

    public void WithdrawAmount()
    {
        throw new NotImplementedException();
    }
}