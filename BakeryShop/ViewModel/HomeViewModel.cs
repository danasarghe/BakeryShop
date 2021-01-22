using BakeryShop.Models;
using System.Collections.Generic;

namespace BakeryShop.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Bread> BreadsOfTheWeek { get; set; }
    }
}
