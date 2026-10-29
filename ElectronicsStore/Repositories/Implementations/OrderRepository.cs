using ElectronicsStore.Entities;
using ElectronicsStore.Entities.Enums;

namespace ElectronicsStore.Repositories.Implementations;

internal class OrderRepository : IOrderRepository
{
    public void CreateOrder(Order order)
    {
    }

    public void DeleteOrder(int id)
    {
    }

    public IEnumerable<Order> ReadOrders(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? customerId = null, OrderStatus? status = null)
    {
        return [];
    }
}
