using System.Linq;

namespace BakeryShop.Models
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAllCategories();
        Category GetById(int id);
    }
}
