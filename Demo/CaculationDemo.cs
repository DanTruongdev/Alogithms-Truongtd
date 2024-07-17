using Algorithm.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Demo
{
    public class CaculationDemo
    {
        private readonly Caculation _calculation;

        public CaculationDemo()
        {
            _calculation = new Caculation();
        }

        public void CalSalaryDemo()
        {
            double salary = 100;
            int year = 2;
            var result = _calculation.CalSalary(salary, year);
            Console.WriteLine($"Original salary is {salary}, the salary after {year} years is {result}");
        }

        public void CalSalaryRecursionDemo()
        {
            double salary = 2000;
            int year = 10;
            var result = _calculation.CalSalaryRecursion(salary, year);
            Console.WriteLine($"Original salary is {salary}, the salary after {year} years is {result}");
        }

        public void CalMonthDemo()
        {
            double salary = 100;
            double rate = 2;
            var result = _calculation.CalMonth(salary, rate);
            Console.WriteLine($"Original salary is {salary}, the rate is {rate}, The orgin money  will be double the original money after {result} months");
        }

        public void CalMonthRecursionDemo()
        {
            double salary = 100;
            double rate = 100;
            var result = _calculation.CalMonthRecursion(salary, rate);
            Console.WriteLine($"Original salary is {salary}, the rate is {rate}, The orgin money  will be double the original money after {result} months");
        }
    }
}
