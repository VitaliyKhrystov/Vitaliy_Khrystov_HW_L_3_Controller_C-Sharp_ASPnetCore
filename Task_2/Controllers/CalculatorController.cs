using Microsoft.AspNetCore.Mvc;
using Task_2.Service;

namespace Task_2.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpPost]
        public IActionResult Add(string value1, string value2)
        {
            double result = Calculator.Add(double.Parse(value1), double.Parse(value2));
            return RedirectToAction("Index", "Home", new { id = result });
        }
        [HttpPost]
        public IActionResult Mul(string value1, string value2)
        {
            double result = Calculator.Mul(double.Parse(value1), double.Parse(value2));
            return RedirectToAction("Index", "Home", new { id = result });
        }
        [HttpPost]
        public IActionResult Div(string value1, string value2)
        {
            double result = Calculator.Div(double.Parse(value1), double.Parse(value2));
            return RedirectToAction("Index", "Home", new { id = result });
        }
        [HttpPost]
        public IActionResult Sub(string value1, string value2)
        {
            double result = Calculator.Sub(double.Parse(value1), double.Parse(value2));
            return RedirectToAction("Index", "Home", new { id = result });
        }
    }
}
