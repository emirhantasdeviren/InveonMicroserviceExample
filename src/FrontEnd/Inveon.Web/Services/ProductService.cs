using Inveon.Web.Models.Dto;
using Inveon.Web.Services.IService;
using Inveon.Web.Utility;
using static Inveon.Web.Utility.SD;

namespace Inveon.Web.Services;

public class ProductService : IProductService
{
    private readonly IBaseService _baseService;

    public ProductService(IBaseService baseService)
    {
        _baseService = baseService;
    }

    public async Task<ResponseDto?> CreateProductAsync(CreateProductDto productDto)
    {
        var reqDto = new RequestDto
        {
            ApiType = ApiType.POST,
            Url = SD.ProductApiBase + "/api/Products",
            Data = productDto,
        };

        return await _baseService.SendAsync(reqDto);
    }

    public async Task<ResponseDto?> GetAllProductsAsync()
    {
        var reqDto = new RequestDto
        {
            ApiType = ApiType.GET,
            Url = SD.ProductApiBase + "/api/Products",
        };

        return await _baseService.SendAsync(reqDto);
    }

    public async Task<ResponseDto?> GetProductAsync(Guid id)
    {
        var reqDto = new RequestDto
        {
            ApiType = ApiType.GET,
            Url = SD.ProductApiBase + "/api/Products/" + id,
        };

        return await _baseService.SendAsync(reqDto);
    }

    public async Task<ResponseDto?> UpdateProductAsync(ProductDto productDto)
    {
        var reqDto = new RequestDto
        {
            ApiType = ApiType.PUT,
            Url = SD.ProductApiBase + "/api/Products",
            Data = productDto,
        };

        return await _baseService.SendAsync(reqDto);
    }

    public async Task<ResponseDto?> DeleteProductAsync(Guid id)
    {
        var reqDto = new RequestDto
        {
            ApiType = ApiType.DELETE,
            Url = SD.ProductApiBase + "/api/Products/" + id,
        };
        return await _baseService.SendAsync(reqDto);
    }
}