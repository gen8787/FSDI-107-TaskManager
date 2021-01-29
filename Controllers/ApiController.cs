using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class ApiController : Controller 
    {
        private DataContext db;
        public ApiController(DataContext context)
        {
            db = context;
        }

        // G E T   A L L   T A S K S
        [HttpGet]
        public IActionResult AllTasks()
        {
            var AllTasks = db.Tasks
                .OrderBy(t => t.DueDate)
                // .Where(t => t.Id < 50).Take(25)
                .ToList();
            return Json(AllTasks);
        }

        public IActionResult ClearTasks()
        {
            db.Tasks.RemoveRange(db.Tasks.ToList());
            db.SaveChanges();
            return Content("Tasks removed");
        }

        [HttpGet("api/deletetask/{TaskId}")]
        public IActionResult DeleteTask(int TaskId)
        {
            Task task = db.Tasks.FirstOrDefault(t => t.Id == TaskId);
            db.Tasks.Remove(task);
            db.SaveChanges();

            return Json("Deleted");
        }


        // G E T   O N E   T A S K S
        [HttpGet]
        public IActionResult OneTask()
        {
            return null;
        }


        // C R E A T E   T A S K
        [HttpPost]
        public IActionResult CreateTask([FromBody] Task newTask)
        {
            System.Console.WriteLine("Saving new task object..." + newTask.Title);

            // validate / sanitize input HOMEWORK
            if (!ModelState.IsValid)
            {
                return View("Tasks");
            }

            db.Tasks.Add(newTask);
            db.SaveChanges();

            return Json(newTask);
        }
    //<~~ E N D   O F   C O N T R O L L E R ~~> //
    }
}