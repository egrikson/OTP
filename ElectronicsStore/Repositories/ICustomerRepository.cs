using ElectronicsStore.Entities;

namespace ElectronicsStore.Repositories;

public interface ICustomerRepository
{
    IEnumerable<Customer> ReadCustomers();

    Customer ReadCustomerById(int id);

    void CreateCustomer(Customer customer);

    void UpdateCustomer(Customer customer);

    void DeleteCustomer(int id);
}
