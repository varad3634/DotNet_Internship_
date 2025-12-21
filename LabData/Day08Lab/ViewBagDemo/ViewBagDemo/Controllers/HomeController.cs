using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string user = "varad";
            ViewData["Msg"] = "Hello "+ user;

            ViewData["count"] = 10;
            TempData["TempMsg"] = "Hii i am from temp";
            ViewBag.Count = 20;

            //return View();

            // For temp data 
            return RedirectToAction(nameof(Print));
        }

        public IActionResult Print() 
        {
            
            return View();
        }
       
    }
}
