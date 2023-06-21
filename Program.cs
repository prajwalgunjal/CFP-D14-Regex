namespace UserRegistration_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           UserRegistration use = new UserRegistration();
            Console.Write("Enter First name :- ");
            string name = Console.ReadLine();
            use.FirstName(name);
            Console.WriteLine();
            Console.Write("Enter Lirst name :- ");
            string Lname = Console.ReadLine();
            use.FirstName(Lname);

        }


    }
}