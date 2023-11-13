/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This is a program 
 
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            /*Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            // <= means less than or equal to
            // >= means greater or equal to
            // != means not equal to



            // < means less than
            if (num < 10)
            {

                Console.WriteLine("The number is less than 10");

            }
            // == means equal to
            else if (num == 10)
            {
                Console.WriteLine("The number is equal to 10");

            }
            // > means greater than 
            else if (num > 10)
            {

                Console.WriteLine("The number is greater than 10");



            }
            Console.Read();
            */

            // boolean variables accept true of false values
            /*bool isSkyBlue = true;
              bool isFoodReady = true;

              // with the && (AND) operator, the statement only exceutes
              // if all statesments are true
              // False && True = False
              // False && False = False
              // True && False = False
              // True && Truse = True
              if(isSkyBlue && isFoodReady) {Console.WriteLine("Nice we can go for the picnic");}
              else { Console.WriteLine("Oh no, we can't go"); }
              */

            Console.WriteLine("Enter your grade to see if you're allowed on the field trip");
                int grade = Convert.ToInt32(Console.ReadLine());

            // with || operator, only one condition only one condition needs to be true
            // False || False = False
            // True || False = True
            // False || True = True
            // True || True = True
            if (grade == 11 || grade == 12)
            {
                Console.WriteLine("You can go to the field trip");
            }
            else{ Console.WriteLine("No, you can not go on the field trip"); }

            /////////////////////////////////////////////////////////////////////////
            if (grade == 11 || grade == 12)
            {
                Console.WriteLine("You can go to the field trip");
            }
            else if (grade != 11 || grade != 12)
            {
                Console.WriteLine("No, you can not go on the field trip");
            }
            Console.ReadLine();

        }

    }

}
