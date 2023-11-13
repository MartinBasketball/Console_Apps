
/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code creates a triangle using asterisks and bases the rows off of what the number the user enters. 
 
 */
using System;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of rows in the asterisk triangle");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine();
            }



        }
    }
}

