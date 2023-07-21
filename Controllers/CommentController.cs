using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IRepository<Comment> _repository;
        public CommentController(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Comment>>> GetAll()
        {
            var comments = await _repository.GetAll();
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> Get(int id)
        {
            var comment = await _repository.Get(id);
            return Ok(comment);
        }

        [HttpPost]
        public async Task<ActionResult<Comment>> Post([FromBody] Comment comment)
        {
            if(!comment.IsValid)
                return BadRequest(comment);

            var createComment = await _repository.Post(comment);
            return Ok(createComment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Comment>> Put([FromRoute] int id, [FromBody] Comment comment)
        {
            var updateComment = await _repository.Put(comment, id);
            return Ok(updateComment);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Comment>> Delete([FromRoute] int id)
        {
            var deleteComment = await _repository.Delete(id);
            return Ok(deleteComment);
        }
    }
}
