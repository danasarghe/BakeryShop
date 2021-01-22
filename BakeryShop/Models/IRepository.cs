namespace BakeryShop.Models
{
    public interface IRepository
    {
        void Add(Bread bread);
        void Update(Bread bread);
        void Delete(Bread bread);
    }
}
