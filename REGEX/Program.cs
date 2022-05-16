// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration Problem Using REGEX!");



while (true)
{
    Console.WriteLine("Please choose the option :\n1)Validating FirstName\n2)Validating LastName");
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
    }
}
