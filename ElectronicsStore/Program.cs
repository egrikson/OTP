using ElectronicsStore.Repositories;
using ElectronicsStore.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace ElectronicsStore;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<FormElectronicsStore>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();

        container.RegisterType<IProductRepository, ProductRepository>(new TransientLifetimeManager());
        container.RegisterType<ICustomerRepository, CustomerRepository>(new TransientLifetimeManager());
        container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
        container.RegisterType<IOrderRepository, OrderRepository>(new TransientLifetimeManager());
        container.RegisterType<ISupplyRepository, SupplyRepository>(new TransientLifetimeManager());

        return container;
    }
}
