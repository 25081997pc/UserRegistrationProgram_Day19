namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the User Registration Program");

            UserRegister userRegister = new UserRegister();

            Console.WriteLine("Enter the EmailID: ");
            string Email = Console.ReadLine();

            if (userRegister.validateEmailID(Email))
            {
                Console.WriteLine("Pattern Match");
            }
            else
            {
                Console.WriteLine("Pattern not Match");
            }
        }
    }
}