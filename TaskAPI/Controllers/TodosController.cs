using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _TodoService;
        private readonly IMapper _mapper;
        public TodosController(ITodoRepository repository,IMapper mapper)
        {
            _TodoService =  repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)
        {
            var myTodos = _TodoService.AllTodos(authorId);
            var mappedTodos = _mapper.Map<ICollection<TodoDto>>(myTodos);
            return Ok(mappedTodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todo = _TodoService.GetTodo(authorId, id);
            if (todo is null)
            {
                return NotFound();
            }

            var mappedTodo = _mapper.Map<TodoDto>(todo);
            return Ok(mappedTodo);
        }

    }
}
