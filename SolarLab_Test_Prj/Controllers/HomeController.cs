using Microsoft.AspNetCore.Mvc;
using SolarLab_Test_Prj.Models;
using SolarLab_Test_Prj.Services;
using System.Diagnostics;

namespace SolarLab_Test_Prj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPerson person;
        public HomeController(ILogger<HomeController> logger, IPerson person)
        {
            _logger = logger;
            this.person = person;
        }

        public IActionResult Index()
        {

            return View(person.Persons);
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