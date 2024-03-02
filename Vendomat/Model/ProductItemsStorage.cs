namespace Vendomat.Model;

public class ProductItemsStorage 
{
    private Dictionary<char, List<Product>> _addresses;

    public ProductItemsStorage()
    {
        _addresses = new Dictionary<char, List<Product>>
        {
            {
                'A', new (new List<Product>
                {
                    new Product(Guid.NewGuid(), "Baba", 3.44F),
                    new Product(Guid.NewGuid(), "Gaba", 3.44F),
                    new Product(Guid.NewGuid(), "Caba", 3.44F),
                    new Product(Guid.NewGuid(), "Zaba", 3.44F),
                    new Product(Guid.NewGuid(), "Xaba", 3.44F),
                    new Product(Guid.NewGuid(), "Caba", 3.44F),
                })
            },
            {
                'B', new (new List<Product>
                {
                    new Product(Guid.NewGuid(), "B3aba", 3.44F),
                    new Product(Guid.NewGuid(), "Ga4ba", 3.44F),
                    new Product(Guid.NewGuid(), "Ca5ba", 3.44F),
                    new Product(Guid.NewGuid(), "Za7ba", 3.44F),
                    new Product(Guid.NewGuid(), "Xa9ba", 3.44F),
                    new Product(Guid.NewGuid(), "Ca23ba", 3.44F),
                })
            },
            {
                'C', new (new List<Product>
                {
                    new Product(Guid.NewGuid(), "Ba232ba", 3.44F),
                    new Product(Guid.NewGuid(), "G45aba", 3.44F),
                    new Product(Guid.NewGuid(), "Ca678ba", 3.44F),
                    new Product(Guid.NewGuid(), "Za54456a", 3.44F),
                    new Product(Guid.NewGuid(), "Xa4564ba", 3.44F),
                    new Product(Guid.NewGuid(), "Ca456423232ba", 3.44F),
                })
            },
            {
                'D', new (new List<Product>
                {
                    new Product(Guid.NewGuid(), "Bab1234454a", 3.44F),
                    new Product(Guid.NewGuid(), "Ga537367ba", 3.44F),
                    new Product(Guid.NewGuid(), "Ca635734ba", 3.44F),
                    new Product(Guid.NewGuid(), "Z245762aba", 3.44F),
                    new Product(Guid.NewGuid(), "Xab72a", 3.44F),
                    new Product(Guid.NewGuid(), "Ca2457245ba", 3.44F),
                })
            },
            {
                'E', new (new List<Product>
                {
                    new Product(Guid.NewGuid(), "Baba245727", 3.44F),
                    new Product(Guid.NewGuid(), "Ga27547257ba", 3.44F),
                    new Product(Guid.NewGuid(), "C254727aba", 3.44F),
                    new Product(Guid.NewGuid(), "Z27547aba", 3.44F),
                    new Product(Guid.NewGuid(), "Xa2457ba", 3.44F),
                    new Product(Guid.NewGuid(), "Ca2457ba", 3.44F),
                })
            },
            {
                'F', new (new List<Product>
                {
                    new Product(Guid.NewGuid(), "Ba524727ba", 3.44F),
                    new Product(Guid.NewGuid(), "Gab724572a", 3.44F),
                    new Product(Guid.NewGuid(), "Cab725472a", 3.44F),
                    new Product(Guid.NewGuid(), "Zab45272457a", 3.44F),
                    new Product(Guid.NewGuid(), "Xab254772a", 3.44F),
                    new Product(Guid.NewGuid(), "Ca25472547ba", 3.44F),
                })
            },
        };
    }

    public ProductItemsStorage(Dictionary<char, List<Product>> slotsMap)
    {
        _addresses = slotsMap;
    }

    public void GetItem(char row, int index)
    {
        if (_addresses.ContainsKey(row))
        {
            var slot = _addresses[row];
            var element = slot[index];
            Console.WriteLine(element);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    
}

public class Slots
{
    public Slots(IEnumerable<Product> products)
    {
        _slots = products.ToList();
    }

    private List<Product> _slots;

    public Product this[int index]
    {
        get { return _slots[index]; }
    }
}