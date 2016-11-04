using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public JsonResult JsonData()
        {
            return Json(new
            {
                Id = 1,
                Name = "Albert"
            });
        }

        public FileResult FileDownload()
        {
            //return File("~/images/dotnet-foundation.png", "application/data", "dotnet-foundation.png");
            return File("~/images/dotnet-foundation.png", "image/png", "dotnet-foundation.png");
        }
    }
}
