using Algorithm.Dao;
using Algorithm.Objects;

namespace Algorithm.Demo
{
    public class ProductDemo
    {   private readonly ProductHandler _product;
        private List<Product> ProductList {  get; set; }
        private List<Category> CategoryList {  get; set; }

        public ProductDemo()
        {
            _product = new ProductHandler();
            ProductList = new List<Product>()
            {
                new Product("CPU", 750, 10, 1),
                new Product( "RAM", 50, 2, 2),
                new Product("HDD", 70, 1, 2),
                new Product("Main", 400, 3, 1),
                new Product("Keyboard", 30, 8, 4),
                new Product("Mouse", 25, 50, 4),
                new Product("VGA", 60, 35, 3),
                new Product("Monitor", 120,28, 2),
                new Product("Case", 120, 28, 3)
            };
            CategoryList = new List<Category>()
            {
                new Category(1, "Comuter"), 
                new Category(2, "Memory"),
                new Category(3,"Card"),
                new Category(4,"Acsesory")
            };
        }

        public void FindProductTest()
        {
            var findProductResult = _product.FindProduct(ProductList, "vga");
            Console.WriteLine("Find product result:");
            Console.WriteLine(findProductResult);
            Console.WriteLine();
        }

        public void FindProductByCategoryTest()
        {
            var findCategoryResult = _product.FindProductByCategory(ProductList, 4);
            PrintList(findCategoryResult, "Find product by category result:");
        }


        public void FindProductByPriceTest()
        {
            var findPriceResult = _product.FindProductByPrice(ProductList, 50);
            PrintList(findPriceResult, "Find product by price result:");
        }

        public void SortByPriceTest()
        {
            var sortPriceResult = _product.SortByPrice(ProductList);
            PrintList(sortPriceResult, "Sort product by price result:");
        }

        public void SortByNameTest()
        {
            var sortNameResult = _product.SortByName(ProductList);
            PrintList(sortNameResult, "Sort product by name result:");
        }

        public void SortByCategoryNameTest()
        {
            var sortCategoryNameResult = _product.SortByCategoryName(ProductList, CategoryList);
            PrintList(sortCategoryNameResult, "Sort product by category name result:");
        }


        public void MapProductByCategoryTest()
        {
            var mapProductByCategoryResult = _product.MapProductByCategory(ProductList, CategoryList);
            PrintList(mapProductByCategoryResult, "map product by category result:");
        }

        public void MinByPriceTest()
        {
            var minByPriceResult = _product.MinByPrice(ProductList);
            Console.WriteLine(minByPriceResult);
        }

        public void MaxByPriceTest()
        {
            var maxByPriceResult = _product.MaxByPrice(ProductList);
            Console.WriteLine(maxByPriceResult);
        }

        private void PrintList<T>(List<T> list, string title)
        {
            Console.WriteLine(title);
            foreach (T e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
    }
}
