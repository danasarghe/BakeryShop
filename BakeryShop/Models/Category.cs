﻿using System.Collections.Generic;

namespace BakeryShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Bread> Breads { get; set; }
    }
}
