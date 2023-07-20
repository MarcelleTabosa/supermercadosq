using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _repository;
        public ProductController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await _repository.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var product = await _repository.Get(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post([FromBody] Product product)
        {
            var createProduct = await _repository.Post(product);
            return Ok(createProduct);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Put([FromRoute] int id, [FromBody] Product product)
        {
            var updateProduct = await _repository.Put(product, id);
            return Ok(updateProduct);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete([FromRoute] int id)
        {
            var deleteProduct = await _repository.Delete(id);
            return Ok(deleteProduct);
        }
    }
}
