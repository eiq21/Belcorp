using Belcorp.Data.Abstract;
using Belcorp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Belcorp.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _categoryRepository;
        public CategoryService(IGenericRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<Category> AddCategory(Category category)
        {
           return await _categoryRepository.AddAsync(category);
        }

        //public void DeleteCategory(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoryRepository.GetAllAsync();
        }

        //public Category GetCategoryById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Category UpdateCategory(Category resource)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public interface ICategoryService
    {
        Task<Category> AddCategory(Category category);
        Task<IEnumerable<Category>> GetAllCategories();

        //Category GetCategoryById(int id);

        //Category UpdateCategory(Category resource);

        //void DeleteCategory(int id);
    }
}
