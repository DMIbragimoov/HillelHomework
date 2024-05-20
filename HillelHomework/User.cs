﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HillelHomework
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get;  set; }
        public byte Age { get; init; }
        public Gender UserGender { get; set; }

        Regex reg = new Regex(pattern: "^[A-Z][a-zA-Z]*$");

        public User()
        {

        }
        public User(byte age)
        {
            Age = age;
        }

        public void ChangeGender(string userInput)
        {
            
           
            if (Enum.TryParse(userInput, out Gender genderByName) && Enum.IsDefined(typeof(Gender), genderByName))
            {
                UserGender = genderByName;
            }
            else if (int.TryParse(userInput, out int numericValue) && Enum.IsDefined(typeof(Gender), numericValue))
            {
                UserGender = (Gender)numericValue;
            }
            else
            {
                Console.WriteLine("Incorrect input!Try again:");
            }
        }
        public bool ValidateNameInput(string userInput)
        {
            return reg.IsMatch(userInput);
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
