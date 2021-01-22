using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop.Models
{
    public class BreadRepository : IBreadRepository
    {
        private readonly BakeryDbContext _bakeryDbContext;

        public BreadRepository(BakeryDbContext bakeryDbContext)
        {
            _bakeryDbContext = bakeryDbContext;
        }
        

        public IEnumerable<Bread> BreadOfTheWeek()
        {
            return _bakeryDbContext.Breads.Include(b => b.Category).Where(b => b.IsBreadOfTheWeek);
        }

        public void Delete(Bread bread)
        {
            _bakeryDbContext.Remove(bread);
        }

        public IEnumerable<Bread> GetAll()
        {
            return _bakeryDbContext.Breads.Include(c => c.Category);
        }

        public Bread GetById(int id)
        {
            return _bakeryDbContext.Breads.FirstOrDefault(b => b.BreadId == id);
        }

        
    }
}
