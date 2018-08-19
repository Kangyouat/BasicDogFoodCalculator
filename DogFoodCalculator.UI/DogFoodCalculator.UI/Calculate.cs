using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogFoodCalculator.UI
{
    public class Calculate
    {
        public static int CalculateCalories(int userInput)
        {
            bool valid = true;
            try
            {
                while (valid)
                {
                    if (userInput <= 0)
                    {
                        Console.WriteLine("You must type in a positive number. Try again next time.");
                        Console.ReadKey();
                        valid = false;
                    }

                    else
                        if (userInput >= 400)
                    {
                        Console.WriteLine();
                        Console.WriteLine("I think your dog is overweight...try again when your dog's weight is lower.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        valid = false;
                    }

                    else
                       if (userInput > 0 && userInput <= 399)
                    {
                        double restingEnergyRequirements = (int)Math.Round((Math.Pow(userInput, 0.75) * 70));

                        Console.WriteLine($"You need to feed your dog {restingEnergyRequirements} calories per day");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        valid = false;
                    }
                    else
                    {
                        valid = false;
                    }

                }
            }
            catch (FormatException)
            {
                Console.Write("You must enter a whole number.");
            }
            return userInput;
        }
    }
}
