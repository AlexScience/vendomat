namespace Vendomat.Models;

public sealed class Product
{
    public Guid Id { get; init; }
    public string Name { get; }
    public int Price { get; }

    public Product(Guid id, string name, int price)
    {
        Name = name;
        Price = price;
        Id = id;
    }

    public static Product Create(string name, int price)
    {
        return new Product(Guid.NewGuid(), name, price);
    }
    
    public override string ToString() => $"Guid: {Id} | Name: {Name} | Price: {Price}";
}