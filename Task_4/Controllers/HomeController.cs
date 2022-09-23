﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Task_4.Service;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IHostEnvironment Env { get; }

        public HomeController(IHostEnvironment env)
        {
            Env = env;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult GetFile()
        {

                string path = Path.Combine(Env.ContentRootPath, "wwwroot\\img\\Description.docx");
                var memory = new MemoryStream();

                using (var stream = new FileStream(path, FileMode.Open))
                {
                    stream.CopyTo(memory);
                }
                memory.Position = 0;
                var ext = Path.GetExtension(path).ToLowerInvariant();
                return File(memory, GetTypes()[ext], Path.GetFileName(path));

        }


        [HttpPost]
        public IActionResult  GetFilePost(bool button)
        {
            if (button)
            {
                string path = Path.Combine(Env.ContentRootPath, "wwwroot\\img\\Description.docx");
                var memory = new MemoryStream();

                using (var stream = new FileStream(path, FileMode.Open))
                {
                    stream.CopyTo(memory);
                }
                memory.Position = 0;
                var ext = Path.GetExtension(path).ToLowerInvariant();
                return File(memory, GetTypes()[ext], Path.GetFileName(path));
            }
            return View("Index");
        }

        private Dictionary<string, string> GetTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain" },
                {".pdf", "aplication/pdf" },
                {".docx", "application/vnd.ms-word" },
                {".doc", "application/vnd.ms-word" },
                {".xls", "application/vnd.ms-exel" },
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" }

                // https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types
            };
        }
    }
}
