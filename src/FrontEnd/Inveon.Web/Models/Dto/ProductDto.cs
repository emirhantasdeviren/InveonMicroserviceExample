namespace Inveon.Web.Models.Dto;

public class ProductDto
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; } = 0.0;
    public string Description { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
}
