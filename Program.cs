namespace Assignment_3._1._2
{
    //This program creates a method to determine if a year is a leap year.
    //Status: Complete
    
    internal class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;
            string userQuit = "";
            while (userContinue)
            {
                int yearEntered = GetYear();
                bool isLeapYear = IfYearIsLeap(yearEntered);

                if (isLeapYear)
                {
                    Console.WriteLine($"{yearEntered} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{yearEntered} is not a leap year.");
                }
                Console.WriteLine("To quit enter Q, or press ENTER to continue");
                userQuit = Console.ReadLine();
                if ((userQuit == "Q") || (userQuit == "q"))
                { 
                    userContinue = false; 
                }
            }
        }

        static bool IfYearIsLeap(int yearEntered)
        {
            //Leaps years are divisible by 4, except years div by 100; unless also div by 400 
            bool isLeapYear = false;
            if ((yearEntered % 4 == 0) && (yearEntered % 100 != 0) || (yearEntered % 400 == 0))
            {
                isLeapYear = true;
            }
        
            return isLeapYear;
        }

        static int GetYear()
        {
            int result = 0;
            Console.WriteLine("Please enter a year");
            while (!Int32.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid entry, please try again.");

            }
            return result;
        }
    }
}
