﻿namespace SupermarketPriceComparer.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
