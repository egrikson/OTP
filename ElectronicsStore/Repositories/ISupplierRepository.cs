using ElectronicsStore.Entities;

namespace ElectronicsStore.Repositories;

public interface ISupplierRepository
{
    IEnumerable<Supplier> ReadSuppliers();

    Supplier ReadSupplierById(int id);

    void CreateSupplier(Supplier supplier);

    void UpdateSupplier(Supplier supplier);

    void DeleteSupplier(int id);
}
