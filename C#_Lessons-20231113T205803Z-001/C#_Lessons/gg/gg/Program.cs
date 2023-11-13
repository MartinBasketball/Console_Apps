/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code gets a number from the user and tells them if their number is odd or even.
 
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Enter an integer");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
        }


    }

}



