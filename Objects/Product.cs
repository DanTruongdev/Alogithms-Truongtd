using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Objects
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public Product(string name, double price, int quantity, int categoryId)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            CategoryId = categoryId;
        }
        public override string ToString()
        {
            return $" Product Name: {Name}, Price: {Price}, Quantity: {Quantity}, CategoryId: {CategoryId}";
        }
    }
}
