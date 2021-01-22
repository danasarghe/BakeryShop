using BakeryShop.Models;
using System.Collections.Generic;

namespace BakeryShop.ViewModel
{
    public class BreadListViewModel
    {
        public IEnumerable<Bread> Breads { get; set; }
        public string CurrentCategory { get; set; }
    }
}
