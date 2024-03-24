namespace Vendomat.Models;

public interface IProductItemsStorage
{
    // public bool CellIsEmpty(string address);

    // public void AddProductItems(string address);

    ProductInfo? GetItemInfo(ItemSlot slot);
    Product GetItem(ItemSlot slot);
}