using ElectronicsStore.Entities;
using ElectronicsStore.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ElectronicsStore.Repositories.Implementations;

internal class OrderRepository : IOrderRepository
{
    private readonly DataContext _context;

    private readonly ILogger<OrderRepository> _logger;

    public OrderRepository(DataContext context, ILogger<OrderRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateOrder(Order order)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(order));
        try
        {
            using var transaction = _context.Database.BeginTransaction();
            _context.Orders.Add(order);
            _context.SaveChanges();
            foreach (var orderItem in order.OrderItems)
            {
                _context.OrderItems.Add(OrderItem.CreateElement(order.Id, orderItem.ProductId, orderItem.Count,
                    orderItem.Price));
            }

            _context.SaveChanges();
            transaction.Commit();
            _logger.LogDebug("Добавлен объект с идентификатором {id}", order.Id);
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

    public void DeleteOrder(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var count = _context.Orders.Where(x => x.Id == id).ExecuteDelete();
            _logger.LogDebug("Удалено записей: {count}", count);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<Order> ReadOrders(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? customerId = null, OrderStatus? status = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var orders = _context.Orders.AsNoTracking()
                .Where(x => !dateFrom.HasValue || x.OrderDate >= dateFrom.Value)
                .Where(x => !dateTo.HasValue || x.OrderDate <= dateTo.Value)
                .Where(x => !customerId.HasValue || x.CustomerId == customerId.Value)
                .Where(x => !status.HasValue || x.Status == status.Value)
                .OrderBy(x => x.Id)
                .ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(orders));
            return orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}
