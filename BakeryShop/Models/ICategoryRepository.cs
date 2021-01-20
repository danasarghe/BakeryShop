using System.Collections.Generic;
using System.Linq;

namespace BakeryShop.Models
{
    interface ICategoryRepository
    {
        IQueryable<Category> GetAllCategories();
        Category GetById(int id);
    }
}
