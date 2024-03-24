namespace Vendomat.Models;

public interface IClientBalance
{
    public double Value { get; }
    public void Replenish(int replenishSum);
    public void Withdraw(int withdrawalSum);
    public bool IsEnoughMoney(int checkSum);
}