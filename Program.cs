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
            Console.Write("Enter Last name :- ");
            string Lname = Console.ReadLine();
            use.LastName(Lname);


            Console.WriteLine();
            Console.Write("Enter Email :- ");
            string Email = Console.ReadLine();
            use.Email(Email);


            Console.WriteLine();
            Console.Write("Enter Phone Number :- ");
            string pnno =  Console.ReadLine();
            use.Phone(pnno);

            Console.WriteLine();
            Console.Write("Enter Password :- ");
            string Password = Console.ReadLine();
            use.Password(Password);

        }


    }
}