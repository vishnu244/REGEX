// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration Problem Using REGEX!");



while (true)
{
    Console.WriteLine("Please choose the option :\n1)Validating FirstName\n2)Validating LastName\n3)Email ID\n4)Mobile Number");
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
        default:
            Console.WriteLine("Please select the above options only");
            break;
    }
}
