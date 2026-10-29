using ElectronicsStore.Entities;
using ElectronicsStore.Entities.Enums;

namespace ElectronicsStore.Repositories;

public interface IOrderRepository
{
    IEnumerable<Order> ReadOrders(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? customerId = null, OrderStatus? status = null);

    void CreateOrder(Order order);

    void DeleteOrder(int id);
}
