using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Models
{
    public class BreadRepository : IBreadRepository
    {
        private readonly BakeryDbContext _bakeryDbContext;

        public BreadRepository(BakeryDbContext bakeryDbContext)
        {
            _bakeryDbContext = bakeryDbContext;
        }
        public void Add(Bread bread)
        {
            _bakeryDbContext.Add(bread);
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

        public void Update(Bread bread)
        {
            _bakeryDbContext.Breads.Attach(bread);
            _bakeryDbContext.Entry(bread).State = EntityState.Modified;

        }
    }
}
