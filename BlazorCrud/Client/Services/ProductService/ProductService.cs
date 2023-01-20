using System;
using System.Net.Http.Json;
using BlazorCrud.Shared;

namespace BlazorCrud.Client.Services.ProductService
{
	public class ProductService : IProductService
	{
        private HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<List<Product>>
                ("api/product");
            if (result is not null)
            {
                Products = result;
            }
        }

        public Task UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}

