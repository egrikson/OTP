using ElectronicsStore.Repositories;
using ElectronicsStore.Repositories.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Unity;
using Unity.Lifetime;
using Unity.Microsoft.Logging;

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

        container.AddExtension(new LoggingExtension(CreateLoggerFactory()));

        container.RegisterType<DataContext>(new TransientLifetimeManager());

        container.RegisterType<IProductRepository, ProductRepository>(new TransientLifetimeManager());
        container.RegisterType<ICustomerRepository, CustomerRepository>(new TransientLifetimeManager());
        container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
        container.RegisterType<IOrderRepository, OrderRepository>(new TransientLifetimeManager());
        container.RegisterType<ISupplyRepository, SupplyRepository>(new TransientLifetimeManager());

        return container;
    }

    private static LoggerFactory CreateLoggerFactory()
    {
        var loggerFactory = new LoggerFactory();
        loggerFactory.AddSerilog(new LoggerConfiguration()
            .ReadFrom.Configuration(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build())
            .CreateLogger());
        return loggerFactory;
    }
}
