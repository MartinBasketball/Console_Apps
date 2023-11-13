/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code gets a lower bound and an upper bound and tells the user what the odd numbers are in between the bounds.
 
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Enter the lower bound");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the upper bound");
            int second = Convert.ToInt32(Console.ReadLine());


            int num = first;

        Beginning:

            if (num % 2 != 0) // checks if it has a remainder
            {
                Console.WriteLine(num);
            }

            num++;

            if (num <= second) //
            {
                goto Beginning;
            }

        }
    }
}


