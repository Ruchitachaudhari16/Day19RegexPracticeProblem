using System;
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

        public void ValidateEmail() 
        {
            Console.WriteLine("Enter the Email Address");
            string email = Console.ReadLine();
            string emailAddress = "^[A-Za-z0-9]{3,}([.][a-zA-z]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            if (Regex.IsMatch(email, emailAddress))
            {
                Console.WriteLine("Email Address is Valid");
            }
            else
            {
                Console.WriteLine("Email Address is invalid");
            }
        }
        public void ValidateMobileNumber()
        {
            Console.WriteLine("Enter the Mobile Number");
            string mobno =Console.ReadLine();
           string mobilenumber = "^[+]?[0-9]{2}[ ][0-9]{10}$";
            if (Regex.IsMatch(mobno,mobilenumber))
            {
                Console.WriteLine("Mobile number is Valid");
            }
            else
            {
                Console.WriteLine("Mobile number is invalid");
            }
        }
        public void ValidatePassword()
        {
            //Should have atleast one special character
            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
            string pass = "^(?=[a-zA-Z0-9#@$?-_]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$";
            if (Regex.IsMatch(password,pass))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
        }
    }
}

