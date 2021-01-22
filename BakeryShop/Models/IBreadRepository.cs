using System.Collections.Generic;

namespace BakeryShop.Models
{
    public interface IBreadRepository
    {
        
        IEnumerable<Bread> GetAll();
        IEnumerable<Bread> BreadOfTheWeek();

        Bread GetById(int id);
        


    }
}
