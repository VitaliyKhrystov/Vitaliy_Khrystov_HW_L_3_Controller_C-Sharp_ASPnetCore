using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task_3.Models;
using Microsoft.AspNetCore.Authentication;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpContextAccessor _accessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor)
        {
            _logger = logger;
            _accessor = accessor;
        }
        public IActionResult Index()
        {
            var remoteIpAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            //var remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString(); //2 вариант
            ViewBag.IpAddress = remoteIpAddress;

            var browserInfo = Request.Headers["User-Agent"].ToString();
            ViewBag.BrowserInfo = browserInfo;

            return View();
        }



    }
}