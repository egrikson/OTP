using ElectronicsStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ElectronicsStore.Repositories.Implementations;

internal class SupplyRepository : ISupplyRepository
{
    private readonly DataContext _context;

    private readonly ILogger<SupplyRepository> _logger;

    public SupplyRepository(DataContext context, ILogger<SupplyRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateSupply(Supply supply)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(supply));
        try
        {
            _context.Supplies.Add(supply);
            _context.SaveChanges();
            _logger.LogDebug("Добавлен объект с идентификатором {id}", supply.Id);
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

    public IEnumerable<Supply> ReadSupplies(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? supplierId = null, int? productId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var supplies = _context.Supplies.AsNoTracking()
                .Where(x => !dateFrom.HasValue || x.SupplyDate >= dateFrom.Value)
                .Where(x => !dateTo.HasValue || x.SupplyDate <= dateTo.Value)
                .Where(x => !supplierId.HasValue || x.SupplierId == supplierId.Value)
                .Where(x => !productId.HasValue || x.ProductId == productId.Value)
                .OrderBy(x => x.Id)
                .ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(supplies));
            return supplies;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}
