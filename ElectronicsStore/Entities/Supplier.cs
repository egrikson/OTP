using System.ComponentModel.DataAnnotations;

namespace ElectronicsStore.Entities;

public class Supplier
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; private set; } = string.Empty;

    [Required]
    [MaxLength(255)]
    public string ContactPerson { get; private set; } = string.Empty;

    [Required]
    [MaxLength(50)]
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
