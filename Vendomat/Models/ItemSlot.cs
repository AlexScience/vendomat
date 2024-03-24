namespace Vendomat.Models;

public sealed record ItemSlot(string RowIndex, int ColumnIndex)
{
    public static ItemSlot FromRawString(string rawString)
    {
        var parts = rawString.Split(":");
        var rowIndex = parts[0];
        if (!int.TryParse(parts[1], out var columnIndex))
        {
            throw new InvalidOperationException($"Incorrect product item position: {rawString}");
        }

        return new ItemSlot(rowIndex, columnIndex);
    }
}