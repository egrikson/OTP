using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElectronicsStore.Entities.Enums;

namespace ElectronicsStore.Entities;

public class Order
{
    [Key]
    public int Id { get; private set; }

    public int CustomerId { get; private set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime OrderDate { get; private set; }

    public DeliveryType DeliveryType { get; private set; }

    [MaxLength(500)]
    public string DeliveryAddress { get; private set; } = string.Empty;

    public OrderStatus Status { get; private set; }

    [Browsable(false)]
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
