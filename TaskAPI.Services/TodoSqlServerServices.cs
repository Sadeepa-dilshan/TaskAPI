using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskApi.DataAccess;
using System.Linq;
using System.Collections.Generic;

namespace TaskAPI.Services
{
    public class TodoSqlServerServices : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
