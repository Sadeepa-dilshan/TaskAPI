using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        public AuthorsController(IAuthorRepository service)
        {

            _service = service;

        }

        [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authors = _service.GetAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult getAuthor(int id)
        {
            var author = _service.GetAuthor(id);
            return Ok(author);
        }

    }
}
