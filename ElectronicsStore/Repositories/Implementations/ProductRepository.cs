using ElectronicsStore.Entities;
using ElectronicsStore.Entities.Enums;

namespace ElectronicsStore.Repositories.Implementations;

internal class ProductRepository : IProductRepository
{
    public void CreateProduct(Product product)
    {
    }

    public void DeleteProduct(int id)
    {
    }

    public Product ReadProductById(int id)
    {
        return Product.CreateEntity(0, string.Empty, string.Empty, ProductCategory.None, ProductFeatures.None, 0);
    }

    public IEnumerable<Product> ReadProducts()
    {
        return [];
    }

    public void UpdateProduct(Product product)
    {
    }
}
