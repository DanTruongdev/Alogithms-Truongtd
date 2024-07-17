using Algorithm.Demo;
using Algorithm.Objects;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDemo productDemo = new ProductDemo();
            productDemo.FindProductTest();
            productDemo.FindProductByCategoryTest();
            productDemo.FindProductByPriceTest();
            productDemo.SortByPriceTest();
            productDemo.SortByNameTest();
            productDemo.SortByCategoryNameTest();
            productDemo.MapProductByCategoryTest();
            productDemo.MinByPriceTest();
            productDemo.MaxByPriceTest();

            CaculationDemo caculationDemo = new CaculationDemo();
            caculationDemo.CalSalaryDemo();
            caculationDemo.CalSalaryRecursionDemo();
            caculationDemo.CalMonthDemo();
            caculationDemo.CalMonthRecursionDemo();


            var menus = new List<Menu>
            {
                new Menu(1, "Thể thao", 0),
                new Menu(2, "Xã hội", 0),
                new Menu(3, "Thể thao trong nước", 1),
                new Menu(4, "Giao thông", 2),
                new Menu(5, "Môi trường", 2),
                new Menu(6, "Thể thao quốc tế", 1),
                new Menu(7, "Môi trường đô thị", 5),
                new Menu(8, "Giao thông ùn tắc", 4)
            };
            Menu.PrintMenu(menus);


            StackAndQueuDemo stackAndQueuDemo = new StackAndQueuDemo();
            stackAndQueuDemo.QueuDemo();
            stackAndQueuDemo.StackDemo();          
        }


    }
}
