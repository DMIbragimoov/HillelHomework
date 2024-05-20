using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

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
                string? userInputFirstName = Console.ReadLine();
                if (user.ValidateNameInput(userInputFirstName))
                {
                    user.FirstName = userInputFirstName;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format. Please, enter a proper name:");
                }
            }

            Console.Write("Choose new Last Name: ");
            while (true)
            {
                string? userInputLastName = Console.ReadLine();
                if (user.ValidateNameInput(userInputLastName))
                {
                    user.FirstName = userInputLastName;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format. Please, enter a proper name:");
                }
            }
            Console.WriteLine("Choose gender: 1 - Male, 2 - Women, 3 - Unknown");
            while (true)
            {
                string userInputGender = Console.ReadLine();
                if (Enum.TryParse(userInputGender, out Gender genderByName) && Enum.IsDefined(typeof(Gender), genderByName))
                {
                    user.UserGender = genderByName;
                    break;
                }
                else if (int.TryParse(userInputGender, out int numericValue) && Enum.IsDefined(typeof(Gender), numericValue))
                {
                    user.UserGender = (Gender)numericValue;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input!Try again:");
                }
            }


            Console.WriteLine(user.ToString());
        }
            
        }
    }

