using ElectronicsStore.Entities.Enums;

namespace ElectronicsStore.Entities;

public class Product
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Manufacturer { get; private set; } = string.Empty;

    public ProductCategory Category { get; private set; }

    public ProductFeatures Features { get; private set; }

    public decimal Price { get; private set; }

    public static Product CreateEntity(int id, string name, string manufacturer, ProductCategory category,
        ProductFeatures features, decimal price)
    {
        return new Product
        {
            Id = id,
            Name = name ?? string.Empty,
            Manufacturer = manufacturer ?? string.Empty,
            Category = category,
            Features = features,
            Price = price
        };
    }
}
