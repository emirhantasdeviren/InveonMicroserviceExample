using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inveon.Services.ProductsAPI.Models.Entities;

public class Product
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; } = null;
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; } = 0.0;
    public string Description { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
}
