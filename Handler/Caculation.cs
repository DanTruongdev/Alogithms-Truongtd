namespace Algorithm.Dao
{
    public class Caculation
    {
        /**
         * Calculates the salary after a specified number of years with a fixed annual raise.
         * @param salary The initial salary.
         * @param n The number of years.
         * @return The calculated salary after n years.
         */
        public double CalSalary(double salary, int n)
        {
            int year = 0;
            while (year != n)
            {
                salary += 10 * salary / 100;
                year++;
            }
            return salary;
        }

        /**
         * Calculates the salary using recursion after a specified number of years with a fixed annual raise.
         * @param salary The initial salary.
         * @param n The number of years.
         * @return The calculated salary after n years using recursion.
         */
        public double CalSalaryRecursion(double salary, int n)
        {
            if (n == 0)
            {
                return salary;
            }
            return CalSalaryRecursion(salary + (10 * salary / 100), n - 1);
        }

        /**
         * Calculates the number of months required to double the initial amount of money with a specified interest rate.
         * @param money The initial amount of money.
         * @param rate The annual interest rate.
         * @return The number of months required to double the money.
         */
        public double CalMonth(double money, double rate)
        {
            double target = money * 2;
            int month = 0;
            while (money < target)
            {
                money += rate * money / 100;
                month++;
            }
            return month;
        }

        /**
         * Calculates the number of months required to double the initial amount of money using recursion with a specified interest rate.
         * @param money The initial amount of money.
         * @param rate The annual interest rate.
         * @return The number of months required to double the money using recursion.
         */
        public int CalMonthRecursion(double money, double rate)
        {
            double target = money * 2;
            return CalMonthRecursion2(money, rate, target, 0);
        }

        /**
         * Helper method for recursive calculation of the number of months required to double the initial amount of money.
         * @param money The current amount of money.
         * @param rate The annual interest rate.
         * @param target The target amount to reach (double the initial money).
         * @param month The current month count.
         * @return The number of months required to reach the target amount.
         */
        private int CalMonthRecursion2(double money, double rate, double target, int month)
        {
            if (money >= target)
            {
                return month;
            }
            return CalMonthRecursion2(money + (rate * money / 100), rate, target, month + 1);
        }
    }
}
