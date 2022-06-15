namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the User Registration Program");

            UserRegister userRegister = new UserRegister();
            Console.WriteLine("Enter the Password: ");
            string passWord = Console.ReadLine();

            if (userRegister.validatePassword(passWord))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is not valid");
            }
        }
    }
}