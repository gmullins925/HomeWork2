﻿using System;

namespace HW2
{
	class Program
 {

            static int Fib(int n)
            {

                // Declare an array to  
                // store Fibonacci numbers. 
                // 1 extra to handle  
                // case, n = 0 
                int[] f = new int[n + 2];
                int i;

                /* 0th and 1st number of the  
                   series are 0 and 1 */
                f[0] = 0;
                f[1] = 1;

                for (i = 2; i <= n; i++)
                {
                    /* Add the previous 2 numbers 
                       in the series and store it */
                    f[i] = f[i - 1] + f[i - 2];
                }

                return f[n];
            }

            // Driver Code 
            public static void Main()
            {
                int n = 0;
                Console.Write("Enter the sequence number of Fibonacci: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fib(n));
                Console.ReadLine();
            }


        }
}
