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
        public bool FirstName(string FtName)
        {
            bool status;           
            string firstname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(firstname);
            
            if (regex.IsMatch(FtName))
            {
                status = true;
                Console.Write("Name is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter First Letter Capital \n");
            }
            return status;
        }

        public bool LastName(string LtName)
        {
            bool status;
            string lasttname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(lasttname);

            if (regex.IsMatch(LtName))
            {
                status = true;
                Console.Write("Name is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter valid Last Name(Last Name must start with Capital Letter and has minimum of 3characters) \n");
            }
            return status;
        }

        public bool EmailID(string Email)
        {
            bool status;
            string emailID = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex = new Regex(emailID);

            if (regex.IsMatch(Email))
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
        
        public bool MobileNumber(string Mnumber)
        {
            bool status;            
            var mobilenumber = "^[0-9]{2}\\s[0-9]{10}$";
            Regex regex = new Regex(mobilenumber);

            if (regex.IsMatch(Mnumber))
            {
                status = true;
                Console.Write("Mobile Number is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter valid Mobile Number \n");
            }
            return status;
        }

        public bool Password(string Passwordrule1)
        {
            bool status;            
            var password = "^[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(password);

            if (regex.IsMatch(Passwordrule1))
            {
                status = true;
                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter valid Password \n");
            }
            return status;
        }

        public bool PasswordRule2(string passwordrule2)
        {
            bool status;
            var passwordRule2 = "^(?=.*[A-Z])[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(passwordRule2);

            if (regex.IsMatch(passwordrule2))
            {
                status = true;
                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter valid Password \n");
            }
            return status;
        }

        public bool PasswordRule3(string passwordrule3)
        {
            bool status;            
            var passwordRule3 = "^(?=.*[0-9A-Z])[0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(passwordRule3);

            if (regex.IsMatch(passwordrule3))
            {
                status = true;
                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter valid Password \n");
            }
            return status;
        }

        public bool PasswordRule4(string passwordrule4)
        {
            bool status;           
            var passwordRule4 = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
            Regex regex = new Regex(passwordRule4);

            if (regex.IsMatch(passwordrule4))
            {
                status = true;
                Console.Write("Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter valid Password \n");
            }
            return status;
        }


    }
}
