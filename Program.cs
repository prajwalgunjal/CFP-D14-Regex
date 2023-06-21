namespace UserRegistration_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           UserRegistration use = new UserRegistration();
            Console.WriteLine("Enter First name");
            string name = Console.ReadLine();
            use.FirstName(name);

        }
    }
}