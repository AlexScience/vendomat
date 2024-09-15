using Vendomat.Exceptions;

namespace Vendomat.Models;

public class ClientBalance : IClientBalance
{
    public double Value { get; private set; }

    public void Replenish(int replenishSum)
    {
        Value += replenishSum;
    }

    public void Withdraw(int withdrawalSum)
    {
        if (Value < withdrawalSum)
        {
            throw new NotEnoughMoneyException();
        }

        Value -= withdrawalSum;
    }

    public bool IsEnoughMoney(int checkSum)
    {
        return Value >= checkSum;
    }
}