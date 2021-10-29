using System;

namespace Day19UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to REGEX problems");


            string FirstName;
            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();

            UserRegistration.checkFirstName(FirstName);


        }

    }
}
