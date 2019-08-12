using Belcorp.Data.Abstract;
using Belcorp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Belcorp.Service
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> productRepository;
        public ProductService(IGenericRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> AddProduct(Product product)
        {
            return await productRepository.AddAsync(product);
        }

        public async void DeleteProduct(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            await productRepository.DeleteAsync(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await productRepository.GetByIdAsync(id);
        }

        public Task<Product> UpdateProduct(Product product)
        {
            
        }
    }

    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Product> UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
