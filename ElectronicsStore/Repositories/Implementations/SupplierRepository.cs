using ElectronicsStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ElectronicsStore.Repositories.Implementations;

internal class SupplierRepository : ISupplierRepository
{
    private readonly DataContext _context;

    private readonly ILogger<SupplierRepository> _logger;

    public SupplierRepository(DataContext context, ILogger<SupplierRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateSupplier(Supplier supplier)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(supplier));
        try
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            _logger.LogDebug("Добавлен объект с идентификатором {id}", supplier.Id);
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

    public void UpdateSupplier(Supplier supplier)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(supplier));
        try
        {
            _context.Suppliers.Update(supplier);
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

    public void DeleteSupplier(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var count = _context.Suppliers.Where(x => x.Id == id).ExecuteDelete();
            _logger.LogDebug("Удалено записей: {count}", count);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Supplier ReadSupplierById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var supplier = _context.Suppliers.AsNoTracking().First(x => x.Id == id);
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(supplier));
            return supplier;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Supplier> ReadSuppliers()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var suppliers = _context.Suppliers.AsNoTracking().OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(suppliers));
            return suppliers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}
