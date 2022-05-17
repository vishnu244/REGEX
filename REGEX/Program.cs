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
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.FirstName();
            break;
        case 2:
            UserRegistration userRegistration1 = new UserRegistration();
            userRegistration1.LastName();
            break;
        case 3:
            UserRegistration EmailID = new UserRegistration();
            EmailID.EmailID();
            break;
        case 4:
            UserRegistration Mobileno = new UserRegistration();
            Mobileno.MobileNumber();
            break;
        case 5:
            UserRegistration Password8 = new UserRegistration();
            Password8.Password();
            break;
        case 6:
            UserRegistration PasswordR2 = new UserRegistration();
            PasswordR2.PasswordRule2();
            break;
        case 7:
            UserRegistration PasswordR3 = new UserRegistration();
            PasswordR3.PasswordRule3();
            break;
        case 8:
            UserRegistration PasswordR4 = new UserRegistration();
            PasswordR4.PasswordRule4();
            break;
        case 9:
            EmailValidation emailValidation = new EmailValidation();
            emailValidation.EmailID();
            break;
        default:
            Console.WriteLine("Please select the above options only");
            break;
    }
}
