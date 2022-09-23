using Microsoft.AspNetCore.Mvc;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Index()
        {
            Product product = new Product();
            ViewBag.Product = product; /* 2 вариант */

            //return View(product);     /* 1 вариант */
            return View();    /* 2 вариант */
        }
    }
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //    С какими сложностями Вы столкнулись
        //во время реализации представлений двумя разными способами?

        //НЕ СТОЛКНУЛСЯ. ЭТО ОК ИЛИ Я ЧТО-ТО НЕ ПРАВИЛЬНО ПОНЯЛ В УСЛОВИИ ЗАДАНИЯ?

}
