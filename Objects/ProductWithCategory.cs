using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Objects
{
    public class ProductWithCategory : Product
    {
        public string CategoryName { get; set; }
        public ProductWithCategory(string name, double price, int quantity, int categoryId, string categoryName) : base(name, price, quantity, categoryId)
        {
            CategoryName = categoryName;
        }

        public static ProductWithCategory ConvertProductToProductWithCategory(Product product, string categoryName)
        {
            return new ProductWithCategory(product.Name, product.Price, product.Quantity, product.CategoryId, categoryName);
        }
        public override string ToString()
        {
            return base.ToString() + $", Category name: {CategoryName}";
        }
    }
}
