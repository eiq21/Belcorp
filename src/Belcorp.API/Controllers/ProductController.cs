using Belcorp.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Belcorp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        //[HttpGet]
        //public async Task<IActionResult> Get() {

        //}
    }
}