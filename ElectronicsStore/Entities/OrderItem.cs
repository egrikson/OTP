namespace ElectronicsStore.Entities;

public class OrderItem
{
    public int OrderId { get; private set; }

    public int ProductId { get; private set; }

    public int Count { get; private set; }

    public decimal Price { get; private set; }

    public static OrderItem CreateElement(int orderId, int productId, int count, decimal price)
    {
        return new OrderItem
        {
            OrderId = orderId,
            ProductId = productId,
            Count = count,
            Price = price
        };
    }
}
