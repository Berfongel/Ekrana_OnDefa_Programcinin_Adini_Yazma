using Microsoft.AspNetCore.Mvc;
using ProgramcininAdiWebApplication.Models;
using System.Diagnostics;

namespace ProgramcininAdiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(ProgramcininAdi programcininAdi)
        {
            var pname = programcininAdi.Ad;
            var message = string.Empty;
            ViewBag.Message = pname;

            return View("programcininAdi");
        }

        public IActionResult Privacy()
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