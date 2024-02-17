namespace Vendomat.Model;

public interface ICurrencyReceiver
{
    public void AddMoney(Currency currency);
    public void ReturnChange(int changeSum);
}