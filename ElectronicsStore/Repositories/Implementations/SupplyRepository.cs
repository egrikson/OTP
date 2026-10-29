using ElectronicsStore.Entities;

namespace ElectronicsStore.Repositories.Implementations;

internal class SupplyRepository : ISupplyRepository
{
    public void CreateSupply(Supply supply)
    {
    }

    public IEnumerable<Supply> ReadSupplies(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? supplierId = null, int? productId = null)
    {
        return [];
    }
}
