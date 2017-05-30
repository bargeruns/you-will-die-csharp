using System;

namespace youwilldiecs
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthdateString = null;
            DateTime birthDate = DateTime.Now;

            void UserBirthday()
            {
                Console.WriteLine("Please enter your birthdate in format MM/DD/YYYY.");
                birthdateString = Console.ReadLine();
            }

            while (birthdateString == null || birthdateString == "")
            {
                UserBirthday();
            }

            birthDate = DateTime.Parse(birthdateString);
            Console.WriteLine($"You entered {birthDate} as your birthday.");
            
            TimeSpan aliveFor = DateTime.Today - birthDate;
            DateTime deathDate = new DateTime(birthDate.Year+72, birthDate.Month, birthDate.Day);
            TimeSpan daysLeft = deathDate - birthDate;
            Console.WriteLine($"You have been alive for {aliveFor.TotalDays} days. That makes you {DateTime.Today.Year - birthDate.Year} years old.");
            Console.WriteLine($"Statistically speaking, you will die on or around {deathDate}.");
            Console.WriteLine($"You probably have about {daysLeft.TotalDays} days left to go. Don't waste them, and certainly don't try to earn them. They are gifts.");
        }
    }
}
