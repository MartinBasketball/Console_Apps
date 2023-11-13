
/*
 * Name: Martin
 * Class: Comp Sci 20s
 * Description: This Code gives you your wage.
 
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number of hours you worked");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your hourly rate");
            double rate = Convert.ToDouble(Console.ReadLine());


            double overtimehours = hours - 40;
            if (overtimehours < 0) { overtimehours = 0; }
            double regular = rate * (hours - overtimehours);
            double overtime = overtimehours * 1.5 * rate;
            double pay = regular + overtime;


            Console.WriteLine("Regular Pay is " + regular);
            Console.WriteLine("Overtime Pay is " + overtime);
            Console.WriteLine("Total Pay is " + pay);

        }


    }

}




