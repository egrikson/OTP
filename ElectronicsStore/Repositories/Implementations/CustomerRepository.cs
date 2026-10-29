using ElectronicsStore.Entities;

namespace ElectronicsStore.Repositories.Implementations;

internal class CustomerRepository : ICustomerRepository
{
    public void CreateCustomer(Customer customer)
    {
    }

    public void DeleteCustomer(int id)
    {
    }

    public Customer ReadCustomerById(int id)
    {
        return Customer.CreateEntity(0, string.Empty, string.Empty, string.Empty);
    }

    public IEnumerable<Customer> ReadCustomers()
    {
        return [];
    }

    public void UpdateCustomer(Customer customer)
    {
    }
}
