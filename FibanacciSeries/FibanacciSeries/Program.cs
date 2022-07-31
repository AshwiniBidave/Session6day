using System;

namespace FibanacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the  number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of the divisor is :" + sum);
            if (sum == n)
                Console.WriteLine("So " + n + " number is perfect.");
            else
                Console.WriteLine("So " + n + " number is not perfect.");

        }
    }
}
