namespace BakeryShop.Models
{
    public class Bread
    {
        public int BreadId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string ImageThumbnail { get; set; }
        public bool IsBreadOfTheWeek { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
