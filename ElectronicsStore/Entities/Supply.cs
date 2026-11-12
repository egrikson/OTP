using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities;

public class Supply
{
    [Key]
    public int Id { get; private set; }

    public int SupplierId { get; private set; }

    public int ProductId { get; private set; }

    public int Count { get; private set; }

    [Column(TypeName = "numeric(12,2)")]
    public decimal PurchasePrice { get; private set; }

    [Column(TypeName = "timestamp without time zone")]
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
