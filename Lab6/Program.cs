// Lab 6
// S5034
// CIS 199-50
// October 31, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Max Number of Rows
            int maxRow = 10
;
            //
            // Pattern A

            Console.WriteLine("Pattern A");
            Console.WriteLine();

            for (int row = 1; row <= maxRow; row++)  // Loop to add new row until it reaches 10.
            {
                for (int star = 1; star <= row; star++)  // Adding 1 star for each row.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //
            // Pattern B

            Console.WriteLine("Pattern B");
            Console.WriteLine();

            for (int row = maxRow; row >= 1; row--)  // Loop to start at max rows until you reach the last row.
            {
                for (int star = row; star >= 1; star--)  // Loop to add stars, starting at 10 and counting down.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //
            // Pattern C

            Console.WriteLine("Pattern C");
            Console.WriteLine();

            for (int row = maxRow; row >= 1; row--)  // Loop to start at max rows until you reach the last row.
            {
                for (int space = maxRow - row; space >= 1; space--)  // Loop to add spaces depending on which row the outer loop is on.
                {
                    Console.Write(" ");
                }

                for (int star = row; star >= 1; star--)  // Loop to add stars, starting at 10 and ending at 1.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //
            // Pattern D

            Console.WriteLine("Pattern D");
            Console.WriteLine();

            for (int row = 1; row <= maxRow; row++)  // Loop to add new row until it reaches 10.
            {
                for (int space = maxRow - row; space >= 1; space--)  // Loop to add spaces depending on which row the outer loop is on.
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= row; star++)  // Loop to add stars, starting at 1 and ending at 10.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //
            // End
            Console.ReadKey();  // Pause program to see result.
        }
    }
}
