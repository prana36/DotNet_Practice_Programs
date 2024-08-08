using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Fibonacci
    {
       public void fibonacciSerise()
        {
            Console.Write("Enter the Range Fibonacci series: ");
            int range = int.Parse(Console.ReadLine());

            int firstNumber = 0, secondNumber = 1;

            Console.WriteLine("Fibonacci series:");
            Console.Write(firstNumber + " " + secondNumber + " ");

            for (int i = 3; i <= range; i++)
            {
                int nextNumber = firstNumber + secondNumber;
                Console.Write(nextNumber + " ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    }
}
