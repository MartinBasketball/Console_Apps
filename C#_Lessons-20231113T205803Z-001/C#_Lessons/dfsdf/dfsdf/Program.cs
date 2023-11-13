/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code is a number guessing game! It gets a number from the user between 1 and 10 and tells them they got it wrong until they get it right.
 
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 10");



            Random random = new Random();
            int actualNumber = random.Next(1, 11); //makes a random number from 1 to 10 it caps off at 11 because it wont count 10 if it was 1, 10
            bool correctguess = false; 

            while (!correctguess) // while its checking if correctguess is false
            {
                Console.WriteLine("Enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == actualNumber)
                {
                    Console.WriteLine("Congratulations! That was the correct number!");
                    correctguess = true;
                }

                else
                {
                    Console.WriteLine("Wrong guess, try again.");
                }

            }

        }
    }
}



