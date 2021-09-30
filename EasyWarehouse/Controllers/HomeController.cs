using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EasyWarehouse.Controllers
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

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Places()
        {
            return View();
        }

        public IActionResult ProductTypes()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
