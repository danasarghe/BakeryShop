using System.Collections.Generic;
using System.Linq;

namespace BakeryShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BakeryDbContext _bakeryDbContext;

        public CategoryRepository(BakeryDbContext bakeryDbContext)
        {
            _bakeryDbContext = bakeryDbContext;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _bakeryDbContext.Categories;
        }

        public Category GetById(int id)
        {
            return _bakeryDbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
