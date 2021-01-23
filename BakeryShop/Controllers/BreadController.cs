using BakeryShop.Models;
using BakeryShop.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop.Controllers
{
    public class BreadController : Controller
    {
        private readonly IBreadRepository _breadRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BreadController(IBreadRepository breadRepository, ICategoryRepository categoryRepository)
        {
            _breadRepository = breadRepository;
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var bread = _breadRepository.GetById(id);

            if (bread == null)
            {
                return NotFound();
            }
            return View(bread);


        }

        public ViewResult List(string category)
        {
            IEnumerable<Bread> breads;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                breads = _breadRepository.GetAll().OrderBy(p => p.Name);
                currentCategory = "All bread";
            }
            else
            {
                breads = _breadRepository.GetAll().Where(b => b.Category.CategoryName == category);
                currentCategory = _categoryRepository.GetAllCategories().FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }


            return View(new BreadListViewModel
            {
                Breads = breads,
                CurrentCategory = currentCategory

            });

        }

    }
}
