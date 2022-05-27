using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
namespace REGEX
{
    public class CustomExceptions : Exception
    {
        public enum ValidationMessage
        {
            InvalidFirstName, InvalidLastName, 
            InvalidEmailId, InvalidMobileNumber,
            InvalidPasswordRule,
            InvalidSampleEmailId

        }
        public readonly ValidationMessage Type;

        public CustomExceptions(ValidationMessage Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }

    public class CustomUserregistration
    {
        //FirstName
        public string CustomException_FirstName(string message)
        {
            
            try
            {

                if(string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidFirstName, "FirstName Should not be Empty or Null");
                }

                string firstname = "^[A-Z]{1}[a-z]{2,}$";
                Regex regex = new Regex(firstname);

                if (regex.IsMatch(message))
                {                   
                    Console.Write("Name is Valid \n");
                    return "Name is Valid ";
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidFirstName, "Invalid FirstName!Please Enter First Letter Capital");

                }
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(String);
        }

        //LastName
        public string CustomException_LastName(string message)
        {

            try
            {

                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidLastName, "LastName Should not be Empty or Null");
                }

                string lastname = "^[A-Z]{1}[a-z]{2,}$";
                Regex regex = new Regex(lastname);

                if (regex.IsMatch(message))
                {
                    Console.Write("Name is Valid \n");
                    return message;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidLastName, "Invalid LastName!Please Enter First Letter Capital");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(String);
        }

        //Email
        public string CustomException_EmailID(string message)
        {

            try
            {

                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidEmailId, "EmailId Should not be Empty or Null");
                }

                string emailID = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})$";
                Regex regex = new Regex(emailID);

                if (regex.IsMatch(message))
                {
                    Console.Write("EmailID is Valid \n");
                    return message;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidEmailId, "Invalid EmailId!Please check the Pattern");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(String);
        }

        //Mobile Number
        public string CustomException_MobileNumber(string message)
        {

            try
            {

                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidMobileNumber, "MobileNumber Should not be Empty or Null");
                }

                string mobilenumber = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
                Regex regex = new Regex(mobilenumber);

                if (regex.IsMatch(message))
                {
                    Console.Write("MobileNumber is Valid \n");
                    return message;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidMobileNumber, "Invalid MobileNumber!Please check the Pattern");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(String);
        }


        //Password
        public string CustomException_InvalidPasswordRule(string message)
        {

            try
            {

                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidPasswordRule, "Password Should not be Empty or Null");
                }

                var passwordRule = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
                Regex regex = new Regex(passwordRule);

                if (regex.IsMatch(message))
                {
                    Console.Write("Password is Valid \n");
                    return message;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidPasswordRule, "Invalid Password!Please check the Pattern");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(String);
        }

    }

}
*/