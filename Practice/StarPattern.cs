using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class StarPattern
    {
        public void square()
        {
            for (int outerLoop = 0; outerLoop <= 4; outerLoop++)
            {
                for (int innerLoop = 0; innerLoop <= 4; innerLoop++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public void Tringle()
        {
            for (int outerLoop = 0; outerLoop <= 4; outerLoop++)
            {
                for (int innerLoop = 0; innerLoop <= 4; innerLoop++)
                {
                    if ( outerLoop==innerLoop||innerLoop<=outerLoop) { Console.Write("*"); }

                }
                Console.WriteLine();
            }

        }

        public void Tringle1()
        {
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        

        }



        public void Tringle3()
        {
            for (int outerLoop = 5; outerLoop >= 1; --outerLoop)
            {
                for (int innerLoop = 1; innerLoop <= outerLoop; ++innerLoop)
                {
                    Console.Write("*");
                    
                }

                Console.WriteLine();
            }

        }

        public void Tringle4()
        {
            for (int outerLoop = 1; outerLoop <= 4; outerLoop++)
            {
                for (int innerLoop = 1; innerLoop <= 4 - outerLoop; innerLoop++)
                {
                    Console.Write(" ");

                }

                for (int innerLoop1 = 1; innerLoop1 <= 2 * outerLoop - 1; innerLoop1++)
                {
                    Console.Write("*");

                }


                Console.WriteLine();
            }

        }

    }
}
