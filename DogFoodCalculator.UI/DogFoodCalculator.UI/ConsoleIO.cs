using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogFoodCalculator.UI
{
    public class ConsoleIO
    {
        public static int Asking()
        {
            Console.WriteLine("************************");
            Console.WriteLine("**Dog Food Calculator**");
            Console.WriteLine("************************");
            Console.WriteLine();

            Console.WriteLine("Enter your dog's weight in kg to see how much he needs to be fed.");
            Console.WriteLine("(1 kilogram = 2.2 pounds)");
            Console.WriteLine();

            int id = 0;
            
            //it will keep looping until user input is an integer 
            while(!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please enter an integer.");
            }

            return id;
        }
    }
}
