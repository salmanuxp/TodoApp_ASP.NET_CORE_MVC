using TodoApp.Models;

namespace TodoApp.Repository
{
    public interface ITodoRepository
    {

        Todo Add(Todo todo);

        Todo Update(Todo modifiedTodo);

        Todo Delete(int Id);

        Todo GetTodo(int Id);

        IEnumerable<Todo> GetAll();
    }
}