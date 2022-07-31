using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            int n = int.Parse(Console.ReadLine());
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");

        }
    }
}
