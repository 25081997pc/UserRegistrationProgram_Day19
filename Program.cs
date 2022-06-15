namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the User Registration Program");

            UserRegister userRegister = new UserRegister();

            Console.WriteLine("Enter the Mobile Number: ");
            string MobileNum = Console.ReadLine();

            if (userRegister.validateMobileNumber(MobileNum))
            {
                Console.WriteLine("Mobile Number is valid");
            }
            else
            {
                Console.WriteLine("Mobile Number is not valid");
            }
        }
    }
}