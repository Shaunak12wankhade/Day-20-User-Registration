using System;

namespace Day19UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to REGEX problems");

            string FirstName, LastName, email, number;
            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();
            UserRegistration.checkFirstName(FirstName);

            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();
            UserRegistration.checkLastName(LastName);

            Console.Write("Enter your email addresss: ");
            email = Console.ReadLine();
            UserRegistration.checkemail(email);

            Console.Write("Enter your mobile number: ");
            number = Console.ReadLine();
            UserRegistration.checknumber(number);

        }

    }
}
