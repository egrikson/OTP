using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElectronicsStore.Entities.Enums;

namespace ElectronicsStore.Entities;

public class Product
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; private set; } = string.Empty;

    [Required]
    [MaxLength(255)]
    public string Manufacturer { get; private set; } = string.Empty;

    public ProductCategory Category { get; private set; }

    public ProductFeatures Features { get; private set; }

    [Column(TypeName = "numeric(12,2)")]
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
