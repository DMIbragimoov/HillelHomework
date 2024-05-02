using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelHomework
{
    public class User
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public byte Age { get; init; }
        public Gender UserGender { get; private set; }
        public enum Gender
        {
            Male = 1,
            Women,
            Unknown
        }

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
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (Enum.IsDefined(typeof(Gender), userInput)) 
            {
                UserGender = (Gender)userInput;
            }
            else
            {
                Console.WriteLine("Invalid number!");
                ChangeGender();
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
