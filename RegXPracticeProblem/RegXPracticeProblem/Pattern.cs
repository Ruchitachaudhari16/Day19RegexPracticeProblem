﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegXPracticeProblem
{
   public class Pattern
    {
        //UC2:- As a User need to enter a valid Last Name - Last name starts with Cap and has minimum 3 characters
        public void ValidateFirstName()
        {
            Console.WriteLine("Enter the First name ");
            string name = Console.ReadLine();
            string firstName = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }
        public void ValidateLastName()
        {
            Console.WriteLine("Enter the Last name");
            string name = Console.ReadLine();
            string lastName = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name,lastName))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
        }
    }
}
