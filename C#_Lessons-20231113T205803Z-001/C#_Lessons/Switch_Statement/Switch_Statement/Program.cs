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
            /*Console.WriteLine("Type a number from 1-12");

            int month = Convert.ToInt32 (Console.ReadLine());*/

            /*if (number == 1)
            {
                Console.WriteLine("January");
            }
            else if (number == 2) 
            {
                Console.WriteLine("Febuary");
            }
            else if (number == 3) 
            { 
                Console.WriteLine("March");
            }
            else if (number == 4)
            {
                Console.WriteLine("April");
            }
            else if (number == 5)
            {
                Console.WriteLine("May");
            }
            else { Console.WriteLine("You didn't type a correct number."); }*/


            // switch helps us compare one variable (value) to multiple 
            // other cases
            // here the variable month is compared to the numbers
            // from 1-12
            /*switch(month)
            {
                case 1: // compares month to 1, if equal executes the print statement
                    Console.WriteLine("January");
                    break; // break is needed to break out of the switch!
                case 2:
                    Console.WriteLine("Febuary");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("Novemeber");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default: // only executes if all the above cases are false.
                    Console.WriteLine("MUWAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA SHE TALKED TO ME!!!!11!!11111!!");
                    break;
            }*/

            Console.WriteLine("Enter your name to find out your grade");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "greg":
                    Console.WriteLine("85%");
                    break;
                case "magnus":
                    Console.WriteLine("88%");
                    break;
                case "martin":
                    Console.WriteLine("89%");
                    break;
                case "lochlan":
                    Console.WriteLine("69%");
                    break;
                default: Console.WriteLine("Wait a minute.... Who are you?");
                    break;
            }

        }


    }

}


