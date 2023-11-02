using Inveon.Web.Models.Dto;
using Inveon.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Inveon.Web.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        List<ProductDto>? list = null;

        ResponseDto? res = await _productService.GetAllProductsAsync();

        if (res != null && res.IsSuccess)
        {
            list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(res.Result)!);
        }
        return View(list);
    }
}