using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }

        public Product(int id, string name, decimal price, ProductType productType)
        {
            ID = id;
            Name = name;
            Price = price;
            Type = productType;
        }
    }

    public enum ProductType
    {
        Unknown,
        Electronic,
        Clothes
    }
}
