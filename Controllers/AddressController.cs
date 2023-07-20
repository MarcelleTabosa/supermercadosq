using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IRepository<Address> _repository;
        public AddressController(IRepository<Address> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAll()
        {
            var addresses = await _repository.GetAll();
            return Ok(addresses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> Get(int id)
        {
            var address = await _repository.Get(id);
            return Ok(address);
        }

        [HttpPost]
        public async Task<ActionResult<Address>> Post([FromBody] Address address)
        {
            var createAddress = await _repository.Post(address);
            return Ok(createAddress);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Address>> Put([FromRoute] int id, [FromBody] Address address)
        {
            var updateAddress = await _repository.Put(address, id);
            return Ok(updateAddress);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Address>> Delete([FromRoute] int id)
        {
            var deleteAddress = await _repository.Delete(id);
            return Ok(deleteAddress);
        }
    }
}
