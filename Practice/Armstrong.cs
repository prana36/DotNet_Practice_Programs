using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Armstrong
    {
        public void armstrong()
        {
            // Define the range
            int startRange = 1;
            int endRange = 1000;

            Console.WriteLine("Armstrong numbers between {0} and {1} are:", startRange, endRange);

            // Loop through the range
            for (int number = startRange; number <= endRange; number++)
            {
                // Calculate the number of digits
                int numDigits = number.ToString().Length;

                // Calculate the sum of each digit raised to the power of numDigits
                int sum = 0;
                int temp = number;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += (int)Math.Pow(digit, numDigits);
                    temp /= 10;
                }

                // Check if the sum is equal to the original number
                if (sum == number)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
