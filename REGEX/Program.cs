// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration Problem Using REGEX!");



while (true)
{
    Console.WriteLine("Please choose the option :\n1)Validating FirstName\n2)Validating LastName\n3)Email ID\n4)Mobile Number\n5)Password of 8digits\n6)Password with atleast 1 capital letter\n7)Atleast 1number\n8)Atleast 1 special Character\n9)Different Email Formats");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.FirstName(Firstname);
            break;
        case 2:
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            UserRegistration userRegistration1 = new UserRegistration();
            userRegistration1.LastName(Lastname);
            break;
        case 3:
            Console.WriteLine("Enter EmailID");
            string EmailID = Console.ReadLine();
            UserRegistration emailID = new UserRegistration();
            emailID.EmailID(EmailID);
            break;
        case 4:
            Console.WriteLine("Enter MobileNumber");
            var MobileNumber = (Console.ReadLine());
            UserRegistration Mobileno = new UserRegistration();
            Mobileno.MobileNumber(MobileNumber);
            break;
        case 5:
            Console.WriteLine("Enter Password");
            var Password = (Console.ReadLine());
            UserRegistration Password8 = new UserRegistration();
            Password8.Password(Password);
            break;
        case 6:
            Console.WriteLine("Enter Password");
            var PasswordRule2 = (Console.ReadLine());
            UserRegistration PasswordR2 = new UserRegistration();
            PasswordR2.PasswordRule2(PasswordRule2);
            break;
        case 7:
            Console.WriteLine("Enter Password");
            var PasswordRule3 = (Console.ReadLine());
            UserRegistration PasswordR3 = new UserRegistration();
            PasswordR3.PasswordRule3(PasswordRule3);
            break;
        case 8:
            Console.WriteLine("Enter Password");
            var PasswordRule4 = (Console.ReadLine());
            UserRegistration PasswordR4 = new UserRegistration();
            PasswordR4.PasswordRule4(PasswordRule4);
            break;
        case 9:
            Console.WriteLine("Enter EmailID");
            string Email_ID = Console.ReadLine();
            EmailValidation emailValidation = new EmailValidation();
            emailValidation.Email_ID(Email_ID);
            break;
        default:
            Console.WriteLine("Please select the above options only");
            break;
    }
}
