﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Prime
    {
        public void PrimeNo()
        {
            Console.WriteLine("Enter the start of the range:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end of the range:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0 || i ==2 )
                {
                    Console.WriteLine(i);

                }
                else {
                   
                }

                


            }


        }
    }
} 
