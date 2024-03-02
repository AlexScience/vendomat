using Vendomat.Model;

var currecy = new List<Currency>
{
    new Banknote(3),
    new Banknote(10),
    new Coin(10),
};

var products = new List<Product>
{
    new(Guid.NewGuid(), "Bread", 10),
    new(Guid.NewGuid(), "Milk", 1),
};
var vendomat = new Vendomat.Model.Vendomat(products, currecy);

Console.WriteLine(vendomat._bank.GetTotalBalance());
Console.WriteLine(vendomat._bank.GetBanknoteBalance());
Console.WriteLine(vendomat._bank.GetCoinBalance());
Console.WriteLine();