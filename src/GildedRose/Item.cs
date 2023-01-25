using System.Diagnostics;
namespace GildedRose;

[DebuggerDisplay("<Item: Name='{Name,q}' SellIn={SellIn} Quality={Quality}>")]
public sealed class Item
{
    public required string Name { get; init; }

    public required int SellIn { get; set; }

    public required int Quality { get; set; }
}
