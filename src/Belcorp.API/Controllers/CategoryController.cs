using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Belcorp.API.ViewModels;
using Belcorp.Model;
using Belcorp.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Belcorp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get() {
            var categories = await categoryService.GetAllCategories();
            var categoriesViewModel = new List<CategoryViewModel>();
            Mapper.Map(categories, categoriesViewModel);
            return Ok(categoriesViewModel);
        }
    }
}