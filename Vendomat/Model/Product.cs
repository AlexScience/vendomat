namespace Vendomat.Model;

public sealed class Product
{
    public Guid Id { get; init; }
    public string Name { get; }
    public float Price { get; }

    public Product(Guid id, string name, float price)
    {
        Name = name;
        Price = price;
        Id = id;
    }

    public override string ToString() => $"Guid: {Id} | Name: {Name} | Price: {Price}";
}