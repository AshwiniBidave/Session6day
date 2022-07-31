using System;
using System.Collections.Generic;
    using System.Collections;
using System.Linq;
namespace CouponNumber
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {


            int coupon = 10;
            int NumberOfcoupon = 10;


            List<string> generatedcoupon = new List<string>();
            char[] keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890".ToCharArray();


            Console.WriteLine("Coupons: ");
            while (generatedcoupon.Count < coupon)
            {
                var voucher = GenerateVoucher(keys, NumberOfcoupon);
                if (!generatedcoupon.Contains(voucher))
                {
                    generatedcoupon.Add(voucher);
                    Console.WriteLine("\t[#{0}] {1}", generatedcoupon.Count, voucher);
                }
            }

            Console.WriteLine("done");

            Console.ReadLine();
        }

        private static string GenerateVoucher(char[] keys, int lengthOfVoucher)
        {
            return Enumerable
                .Range(1, lengthOfVoucher) // for(i.. ) 
                .Select(k => keys[random.Next(0, keys.Length - 1)])  // generate a new random char 
                .Aggregate("", (e, c) => e + c); // join into a string
        }

    }
}

