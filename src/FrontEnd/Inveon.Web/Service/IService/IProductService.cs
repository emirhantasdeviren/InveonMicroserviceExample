using Inveon.Web.Models.Dto;

namespace Inveon.Web.Service.IService;

public interface IProductService
{
    Task<ResponseDto?> GetProductAsync(Guid id);
    Task<ResponseDto?> GetAllProductsAsync();
    Task<ResponseDto?> CreateProductAsync(CreateProductDto productDto);
    Task<ResponseDto?> UpdateProductAsync(ProductDto productDto);
    Task<ResponseDto?> DeleteProductAsync(Guid id);
}