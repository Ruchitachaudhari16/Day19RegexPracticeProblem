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
            Console.WriteLine("Regex");
            while (true) 
            {

                Console.WriteLine("Regex");
                Console.WriteLine("Choose correct  options");
                Console.WriteLine("1:First Name");
                int choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        pattern.ValidateFirstName();
                        Console.WriteLine("--------------------------");
                        break;

                }
            }
        }
    }
}
