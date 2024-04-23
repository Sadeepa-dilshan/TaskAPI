using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoServices : ITodoRepository
    {
        public List<Todo> AllTodos(int authorId)
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed,
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test",
                Description = "Test",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed,
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test",
                Description = "Test",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed,
            };
            todos.Add(todo3);

            return todos;

        }

        public Todo GetTodo(int authorId,int id)
        {
            throw new NotImplementedException();
        }
    }
}
