using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealBuy.Services;
using RealBuy.Models;

namespace RealBuy.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public  ProductsController(JSONFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JSONFileProductService ProductService { get;  }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery]string ProductId, int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
