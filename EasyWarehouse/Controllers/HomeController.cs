using Warehouse.Domain.Models.Data;
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
            ViewBag.Fillings = StaticData.Places.ToFillingWebModel();
            ViewBag.Counts = StaticData.ProductTypes.ToCountsWebModel();
            var products = StaticData.Products.Where(p => p.DateTime >= System.DateTime.Today).ToWebModel().OrderBy(p => p.DateTime);
            return View(products);
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
            var fillings = StaticData.Places.ToFillingWebModel();
            return View(fillings);
        }

        public IActionResult CountsInfo()
        {
            var counts = StaticData.ProductTypes.ToCountsWebModel();
            return View(counts);
        }

        public IActionResult HistoryInfo()
        {
            var history = StaticData.Products.ToHistoryWebModel();
            return View(history);
        }

        public IActionResult ProductTypes()
        {
            var productTypes = StaticData.ProductTypes.ToWebModel();
            return View(productTypes);
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
