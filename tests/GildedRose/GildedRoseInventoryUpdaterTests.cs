using AutoFixture.Xunit2;

namespace GildedRose.Tests;

public class GildedRoseInventoryUpdaterTests
{
    [Theory, AutoData]
    internal void Test1(GildedRoseInventoryUpdater sut)
    {
        // Arrange/Given
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };

        // Act/When
        sut.UpdateQuality();

        // Assert/Then
        Assert.Equal("fixme", Items[0].Name);
    }
}
