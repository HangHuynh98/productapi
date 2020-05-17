using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTest2.Model;
using apiTest2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private ILogger _logger;
        private IProductsService _service;

        
        public ProductsController(ILogger<ProductsController> logger, IProductsService service)
        {
            _logger = logger;
            _service = service;
            
        }

        [HttpGet("/api/products")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _service.GetProducts();
        }

        [HttpPost("/api/products")]
        public ActionResult<Boolean> AddProduct(Product product)
        {
            
            return _service.AddProduct(product) ;
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<Boolean> UpdateProduct(int id,Product product)
        {
            product.ID = id;
            return _service.UpdateProduct(product);
        }

        [HttpDelete("/api/products/{id}")]
        public ActionResult<Boolean> DeleteProduct(int id)
        {
            
            //_logger.LogInformation("products", _products);
            return _service.DeleteProduct(id);
        }
    }
}
