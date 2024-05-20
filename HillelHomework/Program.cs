using System;

namespace HillelHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(9);

            Console.Write("Choose new First Name: ");
            while (true)
            {
                string? userFirstName = Console.ReadLine();
                try
                {
                    user.ChangeName(userFirstName, "firstname");
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input.Please, enter a proper name:");
                }


            }

            Console.Write("Choose new Last Name: ");
            while (true)
            {
                string? userLastName = Console.ReadLine();
                try
                {
                    user.ChangeName(userLastName, "lastname");
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input.Please, enter a proper name:");
                }
                

            }
            Console.WriteLine("Choose gender: 1 - Male, 2 - Women, 3 - Unknown");
            while (true)
            {
                try
                {
                    string? userGender = Console.ReadLine().ToLower();
                    user.ChangeGender(userGender);
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input.Please, enter a proper gender:");
                }
            }
            Console.WriteLine(user.ToString());
        }
    }
}
