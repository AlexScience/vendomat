namespace Vendomat.Model;

public class ListProduct
{
    private List<Product> _products;

    public void AddProduct(Product product)
    {
        _products = new List<Product>();
    }
}