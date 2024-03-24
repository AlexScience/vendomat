namespace Vendomat.Exceptions;

public class ProductNotAvailableException : Exception
{
    public ProductNotAvailableException() : base("Product is not available")
    {
    }
}