using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Models
{
    public class Repository : IRepository
    {
        private readonly BakeryDbContext _bakeryDbContext;

        public Repository(BakeryDbContext bakeryDbContext)
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
        public void Update(Bread bread)
        {
            _bakeryDbContext.Breads.Attach(bread);
            _bakeryDbContext.Entry(bread).State = EntityState.Modified;

        }
    }
}
