/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code gets text from the user and prints text
 
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            /*int counter = 10;

        beginning:  // this is a label

            Console.WriteLine(counter);
            counter = counter + 10;

            if (counter > 10)
            {
                goto beginning; // going back to the label
            }*/

            /*int counter = 1;

            while (counter >0) // this condition must be true for the loop to work at all
                // the condition must become false at some point to prevent an infinite loop
            {
                Console.WriteLine(counter);

                counter++;
            }*/

            /* bool keepRunning = true;
             string decision = "y";

             while (keepRunning)
             {
                 Console.WriteLine("This loop is running");
                 Console.WriteLine("Do you want to stop it? press Y for yes and N for no");
                 decision = Console.ReadLine();

                 if(decision == "n") { keepRunning = false; }


             }*/

            // do while loops will always work at least one time
            // because it perfroms the action first, then checks the condition

            /*
            int counter = 10;

        beginning:  // this is a label

            Console.WriteLine(counter);
            counter = 0;
           
             if (counter < 10)
            {
                goto beginning; // going back to the label
            }*/

            /*
           int counter = 1;
           do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 10); // regardless of whether it is true or false, the loop will work once.
            */
            // the condition needs to be true to run it more than once

            // initialization is i=0
            //boolean expression is i<10
            // update is i++
            // the loop will continue to work as long as the boolean expression is correct

            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*10);
            }

            // initialization i=10
            // boolean expression is i<=100
            // update is i+=10 whcih means i = i + 10

            // counts down 10 to 1
            for (int i = 10;i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // an infinite loop because the boolean expression never becomes false
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine(i);
            }*/
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String[] names = { "Greg", "Daniel", "Magnus", "Martin" }; // array

            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }

            // there is a better way to loop through arrays
            foreach(String name in names)
            {
                Console.WriteLine(name);
            }

            int[] numbers = { 10, 20, 30, 100 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }


    }

}



