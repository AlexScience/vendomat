namespace Vendomat.Model;

public class ProductItemsStorage
{
    private Cell[,] _cells;
    private static Dictionary<string, int> _addresses;

    public ProductItemsStorage(int rowsCount,int columnsCount)
    {
        _cells = new Cell[rowsCount, columnsCount];
    }
}