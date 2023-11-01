using AutoMapper;
using Inveon.Services.ProductsAPI.Models.Dto;
using Inveon.Services.ProductsAPI.Models.Entities;
using Microsoft.Extensions.Options;

namespace Inveon.Services.ProductsAPI;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ProductDto, Product>().ReverseMap();
            config.CreateMap<Product, CreateProductDto>().ReverseMap();
            config.CreateMap<Product, UpdateProductDto>().ReverseMap();
        });

        return mappingConfig;
    }
}