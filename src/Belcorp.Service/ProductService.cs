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
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Product> _productRepository;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
            _productRepository = _uow.GetRepository<Product>();
        }
        public async Task<Product> AddProduct(Product product)
        {
            return await _productRepository.AddAsync(product);
        }

        public async void DeleteProduct(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateAsync(product);
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
