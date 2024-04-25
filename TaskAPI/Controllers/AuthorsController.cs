using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors(string job,string search)
        {
            var authors = _service.GetAuthors(job,search);
            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);

            return Ok(mappedAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult getAuthor(int id)
        {
            var author = _service.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            var mapppedAuthor = _mapper.Map<AuthorDto>(author);
            return Ok(mapppedAuthor);
        }

    }
}
