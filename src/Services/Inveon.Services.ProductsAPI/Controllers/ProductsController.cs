using AutoMapper;
using Inveon.Services.ProductsAPI.Data;
using Inveon.Services.ProductsAPI.Models.Dto;
using Inveon.Services.ProductsAPI.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inveon.Services.ProductsAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _db;
    private IMapper _mapper;
    private ResponseDto _res;

    public ProductsController(AppDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
        _res = new ResponseDto();
    }

    [HttpGet]
    public ResponseDto Get()
    {
        try
        {
            IEnumerable<Product> products = _db.Products.ToList();

            _res.Result = _mapper.Map<IEnumerable<ProductDto>>(products);
            _res.IsSuccess = true;
        }
        catch (Exception e)
        {
            _res.Message = e.Message;
        }

        return _res;
    }

    [HttpGet]
    [Route("{id:guid}")]
    public ResponseDto Get(Guid id)
    {
        try
        {
            Product product = _db.Products.Where(p => p.Id == id).FirstOrDefault() ?? throw new Exception("Product not found.");

            _res.Result = _mapper.Map<ProductDto>(product);
            _res.IsSuccess = true;

        }
        catch (Exception e)
        {
            _res.Message = e.Message;
        }

        return _res;
    }

    [HttpPost]
    public ResponseDto Post([FromBody] CreateProductDto productDto)
    {
        try
        {
            Product product = _mapper.Map<Product>(productDto);
            _db.Products.Add(product);
            _db.SaveChanges();

            _res.Result = _mapper.Map<ProductDto>(product);
            _res.IsSuccess = true;
        }
        catch (Exception e)
        {
            _res.Message = e.Message;
        }

        return _res;
    }

    [HttpPut]
    public ResponseDto Put([FromBody] UpdateProductDto productDto)
    {
        try
        {
            Product product = _db.Products.FirstOrDefault<Product>(p => p.Id == productDto.Id) ?? throw new Exception("Product not found.");
            _mapper.Map(productDto, product);
            product.UpdatedAt = DateTime.UtcNow;

            _db.Products.Update(product);
            _db.SaveChanges();

            _res.Result = _mapper.Map<ProductDto>(product);
            _res.IsSuccess = true;
        }
        catch (Exception e)
        {
            _res.Message = e.Message;
        }

        return _res;
    }

    [HttpDelete]
    public ResponseDto Delete(Guid id)
    {
        try
        {
            Product product = _db.Products.FirstOrDefault(p => p.Id == id) ?? throw new Exception("Product not found.");

            _db.Products.Remove(product);
            _db.SaveChanges();

            _res.IsSuccess = true;
        }
        catch (Exception e)
        {
            _res.Message = e.Message;
        }

        return _res;
    }
}