namespace Inveon.Services.ProductsAPI.Models.Dto;

public class CreateProductDto
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; } = 0.0;
    public string Description { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
}