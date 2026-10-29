using ElectronicsStore.Entities;

namespace ElectronicsStore.Repositories.Implementations;

internal class SupplierRepository : ISupplierRepository
{
    public void CreateSupplier(Supplier supplier)
    {
    }

    public void DeleteSupplier(int id)
    {
    }

    public Supplier ReadSupplierById(int id)
    {
        return Supplier.CreateEntity(0, string.Empty, string.Empty, string.Empty);
    }

    public IEnumerable<Supplier> ReadSuppliers()
    {
        return [];
    }

    public void UpdateSupplier(Supplier supplier)
    {
    }
}
