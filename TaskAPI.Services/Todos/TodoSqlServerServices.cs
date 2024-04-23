using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskApi.DataAccess;
using System.Linq;
using System.Collections.Generic;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlServerServices : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos(int authorId)
        {
            return _context.Todos.Where(t => t.AuthorId == authorId).ToList();
        }
        public Todo GetTodo(int authorId, int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id && t.AuthorId == authorId);
        }
    }
}
