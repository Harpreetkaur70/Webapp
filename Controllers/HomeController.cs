using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webapp.Models;

namespace Webapp.Controllers
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
       
        [HttpPost]
        public IActionResult Index(DateTime date,int days)
        {
            
            ViewBag.date = string.Format("Date: {0}",date);
            ViewBag.days = string.Format("Days: {0}",days);

           ViewBag.dat = "Result: "+date.AddDays(days);
         
            return View();
        }
    }
}