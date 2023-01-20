using System;
using BlazorCrud.Shared;
namespace BlazorCrud.Client.Services.ProductService
{
	public interface IProductService
	{
        List<Product> Products { get; set; }
        Task GetProducts();
        Task<Product?> GetProductById(int id);
        Task CreateProduct(Product product);
        Task UpdateProduct(int id, Product product);
        Task DeleteProduct(int id);
    }
}

