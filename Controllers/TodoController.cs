using Microsoft.AspNetCore.Mvc;
using todolist.Data;
using todolist.Models;
using System.Linq;

namespace todolist.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 顯示待辦事項列表
        public IActionResult Index()
        {
            var todos = _context.Todos.ToList();
            return View(todos);
        }

        // 新增待辦事項
        [HttpPost]
        public IActionResult AddTask(string task, string priority)
        {
            var todo = new Todo
            {
                Task = task,
                Priority = priority,  // 確保這裡正確保存傳遞的 Priority 值
                IsCompleted = false
            };
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // 標記為完成
        [HttpPost]
        public IActionResult MarkAsCompleted(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo != null)
            {
                todo.IsCompleted = true;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
