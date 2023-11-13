/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code gets score
 
 */
using System.ComponentModel.Design;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("What is your score");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 90)
            {
                Console.WriteLine("Your grade is A, great job!");

            }
            else if (num >= 80)
            {
                Console.WriteLine("Your grade is B, nice!");

            }
            else if (num >= 70)
            {
                Console.WriteLine("Your grade is C");

            }
            else if (num >= 60)
            {
                Console.WriteLine("Your grade is a D, what happened?");

            }
            else if (num >= 50)
            {
                Console.WriteLine("Your grade is E, you stupid ahh");

            }
            else if (num <= 49)
            {
                Console.WriteLine("Your grade is F... FAILURE!!!!!!!!!!!");

            }
        
        
        }   


    }

}


