namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the User Registration Program");

            UserRegister userRegister = new UserRegister();
            Console.WriteLine("Enter the Last Name: ");
            string Lastname = Console.ReadLine();

            if(userRegister.validateLastName(Lastname))
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