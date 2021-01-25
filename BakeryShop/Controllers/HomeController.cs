using BakeryShop.Models;
using BakeryShop.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BakeryShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBreadRepository _breadRepository;

        public HomeController(IBreadRepository breadRepository)
        {
            _breadRepository = breadRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                BreadsOfTheWeek = _breadRepository.BreadOfTheWeek()
            };
            return View(homeViewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
