using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    public class EmailValidation
    {
        public void EmailID()
        {
            Console.WriteLine("Enter EmailID");
            string EmailID = Console.ReadLine();
            string emailID = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(emailID);

            if (regex.IsMatch(EmailID))
            {
                Console.Write("EmailID is Valid \n");
            }
            else
            {
                Console.Write("Please Enter valid EmailID \n");
            }

        }
    }

}
