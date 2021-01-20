using System.Collections.Generic;

namespace BakeryShop.Models
{
    interface IBreadRepository
    {
        void Add(Bread bread);
        void Update(Bread bread);
        IEnumerable<Bread> GetAll();

        Bread GetById(int id);
        void Delete(Bread bread);


    }
}
