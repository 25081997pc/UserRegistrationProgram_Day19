﻿namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            ExceptionHandler exceptionHandler = new ExceptionHandler();
            Console.WriteLine("Welcome to the User Registration Program");

            UserRegister userRegister = new UserRegister();
            Console.WriteLine("Enter the First Name: ");
            string firstname = Console.ReadLine();
            try
            {
                if (userRegister.validateFirstName(firstname))
                {
                    Console.WriteLine("FirstName is valid");
                }
                else
                {
                    exceptionHandler.firstname();
                }
            }
            catch(FirstNameException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Enter the Last Name: ");
            string lastname = Console.ReadLine();
            try
            {
                if (userRegister.validateLastName(lastname))
                {
                    Console.WriteLine("LastName is valid");
                }
                else
                {
                    exceptionHandler.lastname();
                }
            }
            catch (LastNameException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-----------------------------");
        }
    }
}       