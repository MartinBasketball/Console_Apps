/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code gets an upper bound from the user and tells them what the sum of the numbers between 0 and the upper bound
 
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Enter the upper bound");
            int upper = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= upper; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }


            Console.WriteLine("The sum of the above number is " + sum);
        }
    }
}

