namespace ElectronicsStore.Entities;

public class Supply
{
    public int Id { get; private set; }

    public int SupplierId { get; private set; }

    public int ProductId { get; private set; }

    public int Count { get; private set; }

    public decimal PurchasePrice { get; private set; }

    public DateTime SupplyDate { get; private set; }

    public static Supply CreateOperation(int id, int supplierId, int productId, int count, decimal purchasePrice)
    {
        return new Supply
        {
            Id = id,
            SupplierId = supplierId,
            ProductId = productId,
            Count = count,
            PurchasePrice = purchasePrice,
            SupplyDate = DateTime.Now
        };
    }
}
