namespace Vendomat.Exceptions;

public class NotEnoughMoneyException : Exception
{
    public NotEnoughMoneyException() : base("Недостаточно средств для покупки")
    {
    }
}