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

                }
            }
        }
    }
}
