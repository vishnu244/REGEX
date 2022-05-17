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
        public bool Email_ID(String email_id)
        {
            bool status;
            string emailID = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(emailID);

            if (regex.IsMatch(email_id))
            {
                status = true;
                Console.Write("EmailID is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter valid EmailID \n");
            }
            return status;
        }
    }

}
