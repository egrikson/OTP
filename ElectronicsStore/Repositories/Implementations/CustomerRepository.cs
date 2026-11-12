using ElectronicsStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ElectronicsStore.Repositories.Implementations;

internal class CustomerRepository : ICustomerRepository
{
    private readonly DataContext _context;

    private readonly ILogger<CustomerRepository> _logger;

    public CustomerRepository(DataContext context, ILogger<CustomerRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateCustomer(Customer customer)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(customer));
        try
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            _logger.LogDebug("Добавлен объект с идентификатором {id}", customer.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
        finally
        {
            _context.ChangeTracker.Clear();
        }
    }

    public void UpdateCustomer(Customer customer)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(customer));
        try
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
        finally
        {
            _context.ChangeTracker.Clear();
        }
    }

    public void DeleteCustomer(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var count = _context.Customers.Where(x => x.Id == id).ExecuteDelete();
            _logger.LogDebug("Удалено записей: {count}", count);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Customer ReadCustomerById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var customer = _context.Customers.AsNoTracking().First(x => x.Id == id);
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(customer));
            return customer;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Customer> ReadCustomers()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var customers = _context.Customers.AsNoTracking().OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(customers));
            return customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}
