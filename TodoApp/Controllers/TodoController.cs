using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Repository;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        public IActionResult Index()
        {


            //var tutorials = new TutorialRepository().GetAll();

            ViewBag.todos = _todoRepository.GetAll();

            //ViewBag.Students = GetStudents();


            return View();


        }

        [HttpGet]
        public IActionResult CreateTodo()
        {


            return View();


        }
        [HttpPost]
        public IActionResult CreateTodo(Todo todo)
        {
            Todo newTodo = _todoRepository.Add(todo);

            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult EditTodo(int id)
        {

            Todo todo = _todoRepository.GetTodo(id);
            return View(todo);


        }
        [HttpPost]
        public IActionResult EditTodo(Todo modifiedData)
        {
            Todo todo = _todoRepository.GetTodo(modifiedData.Id);
            todo.Name = modifiedData.Name;
            todo.Description = modifiedData.Description;
            Todo updateTodo = _todoRepository.Update(todo);

            return RedirectToAction("Index");


        }

        public IActionResult DeleteTodo(int Id)
        {
            Todo deletedTodo = _todoRepository.Delete(Id);

            return RedirectToAction("Index");


        }


    }
}
