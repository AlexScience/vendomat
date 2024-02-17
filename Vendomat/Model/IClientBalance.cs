namespace Vendomat.Model;

public interface IClientBalance
{
    public int Value { get; }
    public void Replenish(int sum);
    public void Withdraw(int sum);
}