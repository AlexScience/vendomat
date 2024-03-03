using Vendomat.Models;

ProductItemsStorage productItemsStorage = new ProductItemsStorage();


Console.WriteLine("Введите строку в формате A:2, где A-F - буквы, а 1-6 - цифры:");
string input = Console.ReadLine();

if (input != null && input.Length == 3)
{
    char letter = input[0];
    int number = int.Parse(input[2].ToString());

    Console.WriteLine(
        " указать номинал в формате “M:5” или “K:100”, где М:5 - обозначение монеты номиналом 5 рублей, К:100 - обозначение купюры номиналом 100 рублей. " +
        "Добавление монет/купюр возможно в произвольном порядке, по одной монете/купюре за раз");

    input = Console.ReadLine();

    if (input != null)
    {
        char currency = input[0];
        int nominal = int.Parse(input[2..input.Length]);

        var product = productItemsStorage.GetItem(letter, number);
        if (product.Price <= nominal)
        {
            Console.WriteLine(product.Name);
        }
    }
}
else
{
    Console.WriteLine("Ошибка: ввод не соответствует ожидаемому формату.");
}