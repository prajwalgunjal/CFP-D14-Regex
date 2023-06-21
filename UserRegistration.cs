using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Regex
{
    internal class UserRegistration
    {
        public void FirstName(string name)
        {
            Regex Checkname = new Regex("^[A-Z][a-z]{2,}");
            Match match = Checkname.Match(name);
            if (match.Success)
            {
                Console.WriteLine("Valid Firstname");
            }
            else {
                Console.WriteLine("not a valid FirstName");
                    }
        }
        public void LastName(string name)
        {
            Regex CheckLname = new Regex("^[A-Z][a-z]{2,}");
            if (CheckLname.IsMatch(name))
            {
                Console.WriteLine("Valid Lastname");
            }
            else {
                Console.WriteLine("not a valid LirstName");
                    }
        }

        public void Email(string email)
        {
            Regex CheckEmail = new Regex("^\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}\\b");

            if (CheckEmail.IsMatch(email))
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("not a valid Email");
            }
        }


    }
}
