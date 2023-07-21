using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _repository;
        public UserController(IRepository<User> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            var users = await _repository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _repository.Get(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            if(!user.IsValid)
                return BadRequest(user);

            var createUser = await _repository.Post(user);
            return Ok(createUser);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Put([FromRoute] int id, [FromBody] User user)
        {
            var updateUser = await _repository.Put(user, id);
            return Ok(updateUser);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete([FromRoute] int id)
        {
            var deleteUser = await _repository.Delete(id);
            return Ok(deleteUser);
        }
    }
}
