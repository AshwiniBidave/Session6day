using System;

namespace FibanacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write("Enter the number of element: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2; //0+1=1
                Console.Write(n3 + " ");
                n1 = n2; //n1=1
                n2 = n3; //n2=1
            }
        }
    }
}
