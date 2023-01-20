using System;
using BlazorCrud.Server.Data;
using BlazorCrud.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.Services.ProductService
{
	public class ProductService : IProductService
	{
        private DataContext _context;

        public ProductService(DataContext context)
		{
            _context = context;
		}

        public Task<Product> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public Task<Product?> UpdateProduct(int productId, Product product)
        {
            throw new NotImplementedException();
        }
    }
}

