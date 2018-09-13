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
            
            //try block is block of code in which exceptions occur
            try
            { 
                //will continue looping until valid is false
                while (valid)
                {
                    //if the user entered a number less than or equal to 0, it will write the following statement and end the loop
                    if (userInput <= 0)
                    {
                        Console.WriteLine("You must type in a positive number. Try again next time.");
                        Console.ReadKey();
                        valid = false;
                    }

                    //if the user entered a number less than or equal to 400, it will write the following statement and end the loop
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

                    //if the user entered a number less than 0 and less than 399, it will write the following statement and end the loop
                    else
                       if (userInput > 0 && userInput <= 399)
                    {
                        //this is a math formula that is equivalent to:(dog weight in kg)^(3/4) then multiply by 70.
                        double restingEnergyRequirements = (int)Math.Round((Math.Pow(userInput, 0.75) * 70));

                        Console.WriteLine($"You need to feed your dog {restingEnergyRequirements} calories per day");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        valid = false;
                    }

                    //if the user entered anything besides what was above, it will automatically be set false and end the loop
                    else
                    {
                        valid = false;
                    }

                }
            }

            //catch block catches and handles try block exceptions
            catch (FormatException)
            {
                Console.Write("You must enter a whole number.");
            }
            return userInput;
        }
    }
}
