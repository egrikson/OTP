using ElectronicsStore.Entities;

namespace ElectronicsStore.Repositories;

public interface ISupplyRepository
{
    IEnumerable<Supply> ReadSupplies(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? supplierId = null, int? productId = null);

    void CreateSupply(Supply supply);
}
