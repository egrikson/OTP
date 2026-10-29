namespace ElectronicsStore.Entities;

public class Supplier
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string ContactPerson { get; private set; } = string.Empty;

    public string Phone { get; private set; } = string.Empty;

    public static Supplier CreateEntity(int id, string name, string contactPerson, string phone)
    {
        return new Supplier
        {
            Id = id,
            Name = name ?? string.Empty,
            ContactPerson = contactPerson ?? string.Empty,
            Phone = phone ?? string.Empty
        };
    }
}
