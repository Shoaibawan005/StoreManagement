using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Store.Infrastructure;
using Store.Domain;
using Store.Application.IServices;
using Store.Domain.Models;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductSRV _iProductSRV;

        public ProductController(IProductSRV iProductSRV)
        {
            _iProductSRV = iProductSRV;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _iProductSRV.GetAllProducts();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductModel modelProduct)
        {
            var result = _iProductSRV.AddProduct(modelProduct);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var result = _iProductSRV.DeleteProduct(id);

            //return Ok(result);
            return Ok(new { message = result });
        }
    }
}
