using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task_2.Models;

namespace Task_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(double id)
        {
            return View(id);
        }

       
    }
}