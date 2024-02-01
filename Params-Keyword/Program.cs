using System;

namespace ParamsKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            // params keyword = a method parameter that takes a variable number of arguments.
            //                  The parameter type must be a single - dimensional array

            double total = CheckOut(1, 4, 5, 10, 3.24);

            Console.WriteLine(total);

            Console.ReadKey();
        }

       static double CheckOut (params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}