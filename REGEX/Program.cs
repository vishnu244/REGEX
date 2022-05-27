// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration Problem Using REGEX!");



while (true)
{
    Console.WriteLine("Please choose the option :\n1)Validating FirstName\n2)Validating LastName\n3)Email ID\n4)Mobile Number\n5)Password of 8digits\n6)Password with atleast 1 capital letter\n7)Atleast 1number\n8)Atleast 1 special Character\n9)Different Email Formats\n10)Custom " +
        "Exception for FirstName\n11)Custom Exception LastName\n12)customException EmailID\n13)Custom Exception Mobile Number\n14)Custom Exception Password\n15)UserRegistration Using Lambda Expressions");
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
        case 10:
            CustomUserregistration C1 = new CustomUserregistration();
            string FirstName = C1.CustomException_FirstName("Vishnu");
            Console.WriteLine(FirstName);
            break;

        case 11:
            CustomUserregistration C2 = new CustomUserregistration();
            string LastName = C2.CustomException_LastName("Vardhan");
            Console.WriteLine(LastName);
            break;

        case 12:
            CustomUserregistration C3 = new CustomUserregistration();
            string Email = C3.CustomException_EmailID("abc.xyz@bl.co.in");
            Console.WriteLine(Email);
            break;

        case 13:
            CustomUserregistration C4 = new CustomUserregistration();
            string Mobilenumber = C4.CustomException_MobileNumber("+91 1234567890");
            Console.WriteLine(Mobilenumber);
            break;

        case 14:
            CustomUserregistration C5 = new CustomUserregistration();
            string PasswordRule = C5.CustomException_InvalidPasswordRule("Vish#123");
            Console.WriteLine(PasswordRule);
            break;
        case 15:
            UserRegistration l1 = new();
            Console.WriteLine("enter firstname");
            string firstName1 = Console.ReadLine();
            string output1 = l1.LambdaExpressionFirstname(firstName1);
            Console.WriteLine(output1);

            UserRegistration l2 = new();
            Console.WriteLine("enter Lastname");
            string lasstName1 = Console.ReadLine();
            string output2 = l2.LambdaExpressionLastname(lasstName1);
            Console.WriteLine(output2);

            UserRegistration l3 = new();
            Console.WriteLine("enter email");
            string email = Console.ReadLine();
            string output3 = l3.LambdaExpressionEmail(email);
            Console.WriteLine(output3);

            UserRegistration l4 = new();
            Console.WriteLine("enter mobilenumber");
            string mobilenumber = Console.ReadLine();
            string output4 = l4.LambdaExpressionPhoneNumber(mobilenumber);
            Console.WriteLine(output4);

            UserRegistration l5 = new();
            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            string output5 = l5.LambdaExpressionpassword(password);
            Console.WriteLine(output5);
            break;

        default:
            Console.WriteLine("Please select the above options only");
            break;
    }
}
