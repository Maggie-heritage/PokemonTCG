using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Trade.Models;

namespace Trade.Controllers
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
            return View();
        }

        public IActionResult Guide()
        {
            return View();
        }

        //public IActionResult Offering()
        //{
        //    return View();
        //}


        //public IActionResult Requesting()
        //{
        //    return View();
        //}

        //public IActionResult Trade()
        //{
        //    return View();
        //}

        //public ActionResult Hello(String name, int score = 4)
        //{
        //    ViewBag.Message = "hi " + name;
        //    ViewBag.score = score;

        //    return View();
        //}

        //matched the parameter ID in the Startup.cs line 61 app.UseEndpoints url pattern endpoints.MapControllerRoute
        //public string Student(String name, int ID =1)
        //{
        //    return System.Web.HttpUtility.HtmlEncode("Hi " + name + ", your ID is: " + ID);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
