using TodoApp.Context;
using TodoApp.Models;

namespace TodoApp.Repository
{
    public class TodoRepository : ITodoRepository
    {
        //private List<Todo> _todos;
        private readonly TodoDbContext _context;
        public TodoRepository(TodoDbContext context)
        {
            _context = context;

        }
        public Todo Add(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return todo;
        }

        public Todo Update(Todo modifiedTodo)
        {
            _context.Update(modifiedTodo);
            _context.SaveChanges();
            return modifiedTodo;
        }

        public Todo Delete(int Id)
        {
            Todo todo = _context.Todos.Find(Id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                _context.SaveChanges();

            }
            return todo;
        }

        public Todo GetTodo(int Id)
        {
            return _context.Todos.Find(Id);
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Todos;
        }

    }
}
