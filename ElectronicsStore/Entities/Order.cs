using ElectronicsStore.Entities.Enums;

namespace ElectronicsStore.Entities;

public class Order
{
    public int Id { get; private set; }

    public int CustomerId { get; private set; }

    public DateTime OrderDate { get; private set; }

    public DeliveryType DeliveryType { get; private set; }

    public string DeliveryAddress { get; private set; } = string.Empty;

    public OrderStatus Status { get; private set; }

    public IEnumerable<OrderItem> OrderItems { get; private set; } = [];

    public static Order CreateOperation(int id, int customerId, DeliveryType deliveryType, string deliveryAddress,
        IEnumerable<OrderItem> orderItems)
    {
        return new Order
        {
            Id = id,
            CustomerId = customerId,
            OrderDate = DateTime.Now,
            DeliveryType = deliveryType,
            DeliveryAddress = deliveryAddress ?? string.Empty,
            Status = OrderStatus.Processing,
            OrderItems = orderItems ?? Enumerable.Empty<OrderItem>()
        };
    }
}
