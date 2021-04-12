using Trade.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Trade.Controllers
{
    public class Account : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Account(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
                

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Offering()
        {
            return View();
        }


        public IActionResult Requesting()
        {
            return View();
        }

        public IActionResult MyRequestingList()
        {
            return View();
        }

        public IActionResult MyOfferingList()
        {
            return View();
        }


        public IActionResult Trade()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
