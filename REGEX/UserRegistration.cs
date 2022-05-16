using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    public class UserRegistration
    {
        public void FirstName()
        {
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            string firstname = "[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(firstname);
            
            if (regex.IsMatch(Firstname))
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Plase Enter First Letter Capital \n");
            }

        }
      
    }
}
