using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HillelHomework
{
    public class User
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public byte Age { get; init; }
        public Gender UserGender { get; private set; }
       
        Regex reg = new Regex(pattern: "^[A-Z][a-zA-Z]*$");
        public User()
        {

        }
        public User(byte age)
        {
            Age = age;
        }

        public void ChangeGender()
        {
            Console.WriteLine("Choose gender: 1 - Male, 2 - Women, 3 - Unknown");
            int.TryParse(Console.ReadLine(), out int userInput);
            if (Enum.IsDefined(typeof(Gender), userInput)) 
            {
                UserGender = (Gender)userInput;
            }
            else
            {
                throw new ArgumentException();
               
            }
        }
        public void ChangeFirstName()
        {
            Console.Write("Input new First Name: ");
        string? userInput = Console.ReadLine();
            if (reg.IsMatch(userInput))
            {
                FirstName = userInput;
            }
            else 
            {
                Console.WriteLine("Incorrect input: Use letters and first name must start with uppercase.");
                ChangeFirstName();
            }

        }

        public void ChangeLastName()
        {
            Console.Write("Inpt new Last Name: ");
            string? userInput = Console.ReadLine();
            if (reg.IsMatch(userInput))
            {
                LastName = userInput;
            }
            else
            {
                Console.WriteLine("Incorrect input: Use letters and last name must start with uppercase");
                ChangeLastName();
            }

        }
       
        

        public override string ToString()
        {
            if (Age < 10)
            {
                return ($"Hi, my name is {FirstName} and last name {LastName}. I am a baby. I am {UserGender}.");
            }
            else 
            {
                return ($"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old. I am {UserGender}.");
            }
        }
    }
}
