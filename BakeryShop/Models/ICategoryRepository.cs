using System.Collections.Generic;

namespace BakeryShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetById(int id);
    }
}
