using Vendomat.Exceptions;
using Vendomat.Models;
using Vendomat.Services.DTO;

namespace Vendomat.Services;

public class ProductItemsStorage : IProductItemsStorage
{
    private readonly Dictionary<ItemSlot, int> _availableItems = new()
    {
        { ItemSlot.FromRawString("A:1"), 6 },
        { ItemSlot.FromRawString("A:2"), 6 },
        { ItemSlot.FromRawString("B:1"), 6 },
        { ItemSlot.FromRawString("B:2"), 6 }
    };
    
    private readonly Dictionary<ItemSlot, Product> _productsMap = new()
    {
        { ItemSlot.FromRawString("A:1"), Product.Create("Snickers", 100) },
        { ItemSlot.FromRawString("A:2"), Product.Create("Mars", 90) },
        { ItemSlot.FromRawString("B:1"), Product.Create("Fanta", 150) },
        { ItemSlot.FromRawString("B:2"), Product.Create("Pepsi", 160) }
    };

    public ProductInfo? GetItemInfo(ItemSlot slot)
    {
        if (!_availableItems.TryGetValue(slot, out var availableCount) || availableCount <= 0)
            return null;

        var product = _productsMap[slot];
        return new ProductInfo(product, availableCount);
    }
    
    public Product GetItem(ItemSlot slot)
    {
        if (!_availableItems.TryGetValue(slot, out var availableCount) || availableCount <= 0)
            throw new ProductNotAvailableException();

        var product = _productsMap[slot];
        _availableItems[slot]--;

        return product;
    }
}