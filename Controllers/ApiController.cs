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

            return Json(list);
        }
    }
}