using System.Diagnostics;
using KhumaloCraftie.Models;
using KhumaloCraftie.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KhumaloCraftie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnotherService _anotherService;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, IAnotherService anotherService, ApplicationDbContext context)
        {
            _logger = logger;
            _anotherService = _anotherService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs() 
        {
            return View();
        }

        public IActionResult MyWork()
        {
            var products = _context.Products.Where(p => p.Availability == true).ToList();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
