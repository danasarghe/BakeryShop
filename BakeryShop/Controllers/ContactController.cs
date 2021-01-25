using Microsoft.AspNetCore.Mvc;

namespace BakeryShop.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
