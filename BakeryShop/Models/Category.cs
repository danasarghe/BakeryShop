using System.Collections.Generic;

namespace BakeryShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public TypeOfBread TypeOfBread { get; set; }
        public string ShortDescription { get; set; }
        public List<Bread> Breads { get; set; }
    }
}
