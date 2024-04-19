using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _TodoService;

        public TodosController(ITodoRepository repository)
        {
            _TodoService =  repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _TodoService.AllTodos();
            if (id is null) return Ok(myTodos);
            myTodos = myTodos.Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }

    }
}
