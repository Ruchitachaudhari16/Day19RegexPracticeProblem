using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegXPracticeProblem
{
   public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            while (true) 
            {
                Console.WriteLine("Regex");
                Console.WriteLine("Choose correct  options");
                Console.WriteLine("1:First Name");
                Console.WriteLine("2:Last Name");
                Console.WriteLine("3:Email Address");
                Console.WriteLine("4:MobileNumber");
                Console.WriteLine("5:Password");
                int choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        pattern.ValidateFirstName();
                        Console.WriteLine("--------------------------");
                        break;

                        case 2:
                        pattern.ValidateLastName();
                        Console.WriteLine("---------------------------");
                        break;

                        case 3:
                        pattern.ValidateEmail();
                        Console.WriteLine("---------------------------");
                        break;

                        case 4:
                        pattern.ValidateMobileNumber();
                        Console.WriteLine("--------------------------");
                        break;

                        case 5:
                        pattern.ValidatePassword();
                        Console.WriteLine("--------------------------");
                        break;


                }
            }
        }
    }
}
