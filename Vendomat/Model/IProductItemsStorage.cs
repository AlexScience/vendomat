namespace Vendomat.Model;

public interface IProductItemsStorage
{
    public bool CellIsEmpty(string address);

    public void AddProductItems(string address);
}