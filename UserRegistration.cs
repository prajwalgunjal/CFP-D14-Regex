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
                Console.WriteLine("Valid firstname");
            }
            else {
                Console.WriteLine("not a valid FirstName");
                    }
        }
    }
}
