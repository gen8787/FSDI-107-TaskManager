using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    public class ApiController : Controller 
    {
        [HttpGet]
        public IActionResult Test()
        {
            var list = new List<string>();
            list.Add("task1");
            list.Add("task2");
            list.Add("task3");

            return Json(list);
        }
    }
}