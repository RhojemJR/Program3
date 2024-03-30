using System.ComponentModel.Design;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeConversion:
            Console.WriteLine("Time conversion");
            Console.WriteLine("(1) - Convert Seconds to Minutes");
            Console.WriteLine("(2) - Convert Minutes to Hours");
            Console.WriteLine("(3) - Convert Hours to Days");
            Console.WriteLine("(4) - Convert Days to Months");
            Console.Write("Enter your choice 1/2/3/4: ");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
            //Convert Seconds to Minutes
            {
                Console.Write("Enter Approximate Time in Seconds:");
                int seconds = Convert.ToInt32(Console.ReadLine());
                int Minutes = seconds / 60;
                Console.WriteLine($"{seconds} Seconds is Approximately {Minutes} Minutes.");
                goto TimeConversion;
            }
            if (choice == 2)
            //Convert Minutes to Hours
            {
                Console.Write("Enter Approximate Time in Minutes:");
                int Minutes = Convert.ToInt32(Console.ReadLine());
                int Hours = Minutes / 60;
                Console.WriteLine($"{Minutes} Minutes is Approximately {Hours} Hours.");
                goto TimeConversion;
            }
            if (choice == 3)
            //Convert Hours to Days 
            {
                Console.Write("Enter Approximate Time in Hours:");
                int Hours = Convert.ToInt32(Console.ReadLine());
                int Days = Hours / 24;
                Console.WriteLine($"{Hours} Hours is Approximately {Days} Days.");
                goto TimeConversion;
            }
            if (choice == 4)
            //Convert Days to Months
            {
                Console.Write("Enter Approximate Time in Days:");
                int Days = Convert.ToInt32(Console.ReadLine());
                int Months = Days / 30;
                Console.WriteLine($"{Days} Days is Approximately {Months} Months.");
                goto TimeConversion;
            }
            else
            {
                Console.WriteLine("Invalid choice enter a number between only 1-4. Please try again.");
                Console.ReadLine();
                goto TimeConversion; 
            }
            
        }
    }
}
