using ElectronicsStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ElectronicsStore.Repositories.Implementations;

internal class ProductRepository : IProductRepository
{
    private readonly DataContext _context;

    private readonly ILogger<ProductRepository> _logger;

    public ProductRepository(DataContext context, ILogger<ProductRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateProduct(Product product)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(product));
        try
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            _logger.LogDebug("Добавлен объект с идентификатором {id}", product.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
        finally
        {
            _context.ChangeTracker.Clear();
        }
    }

    public void UpdateProduct(Product product)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(product));
        try
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
        finally
        {
            _context.ChangeTracker.Clear();
        }
    }

    public void DeleteProduct(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var count = _context.Products.Where(x => x.Id == id).ExecuteDelete();
            _logger.LogDebug("Удалено записей: {count}", count);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Product ReadProductById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var product = _context.Products.AsNoTracking().First(x => x.Id == id);
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(product));
            return product;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Product> ReadProducts()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var products = _context.Products.AsNoTracking().OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(products));
            return products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}
