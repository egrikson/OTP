namespace ElectronicsStore.Entities;

public class Customer
{
    public int Id { get; private set; }

    public string FullName { get; private set; } = string.Empty;

    public string Phone { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public static Customer CreateEntity(int id, string fullName, string phone, string email)
    {
        return new Customer
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            Phone = phone ?? string.Empty,
            Email = email ?? string.Empty
        };
    }
}
