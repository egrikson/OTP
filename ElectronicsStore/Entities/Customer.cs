using System.ComponentModel.DataAnnotations;

namespace ElectronicsStore.Entities;

public class Customer
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(255)]
    public string FullName { get; private set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Phone { get; private set; } = string.Empty;

    [MaxLength(255)]
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
