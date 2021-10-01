using EasyWarehouse.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

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
            var products = StaticData.Products.ToWebModel();
            return View(products);
        }

        public IActionResult ProductDetails(int Id)
        {
            var product = StaticData.Products.SingleOrDefault(p => p.Id == Id).ToWebModel();
            return View(product);
        }

        public IActionResult Places()
        {
            var places = StaticData.Places.ToWebModel();
            return View(places);
        }

        public IActionResult PlaceDetails(int Id)
        {
            var place = StaticData.Places.SingleOrDefault(p => p.Id == Id).ToWebModel();
            return View(place);
        }

        public IActionResult FillingInfo()
        {
            return View();
        }

        public IActionResult CountsInfo()
        {
            return View();
        }

        public IActionResult HistoryInfo()
        {
            return View();
        }

        public IActionResult ProductTypes()
        {
            var productTypes = StaticData.ProductTypes.ToWebModel();
            return View(productTypes);
        }

        public IActionResult GetMobile()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
