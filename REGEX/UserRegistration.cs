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
            string firstname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(firstname);
            
            if (regex.IsMatch(Firstname))
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Please Enter First Letter Capital \n");
            }

        }

        public void LastName()
        {
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            string lasttname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(lasttname);

            if (regex.IsMatch(Lastname))
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Please Enter valid Last Name(Last Name must start with Capital Letter and has minimum of 3characters) \n");
            }

        }

        public void EmailID()
        {
            Console.WriteLine("Enter EmailID");
            string EmailID = Console.ReadLine();
            //string emailID = "^[a-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2})?$";
            string emailID = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
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
        
        public void MobileNumber()
        {
            Console.WriteLine("Enter MobileNumber");
            var MobileNumber =(Console.ReadLine());
            var mobilenumber = "^[0-9]{2}\\s[0-9]{10}$";

            Regex regex = new Regex(mobilenumber);

            if (regex.IsMatch(MobileNumber))
            {
                Console.Write("Mobile Number is Valid \n");
            }
            else
            {
                Console.Write("Please Enter valid Mobile Number \n");
            }

        }
    }
}
