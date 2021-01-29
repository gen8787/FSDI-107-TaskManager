using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class ApiController : Controller 
    {
        // G E T   A L L   T A S K S
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return null;
        }


        // C R E A T E   T A S K
        [HttpPost]
        public IActionResult CreateTask([FromBody] Task newTask)
        {
            System.Console.WriteLine("Saving new task object..." + newTask.Title);

            // validate / sanitize input HOMEWORK

            newTask.Id = 1;

            return Json(newTask);
        }
    //<~~ E N D   O F   C O N T R O L L E R ~~> //
    }
}