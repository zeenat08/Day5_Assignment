using System;
using System.Collections.Generic;
using System.Text;

namespace DAY5_Assignments
{
    class EvenOdd
    {

        public static void NumCheck()
        {
            int num;
            Console.WriteLine("Enter a number to check");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
    

