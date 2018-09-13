using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogFoodCalculator.UI
{
   public class SetUpWorkflow
    {
        internal void Start()
        {
            //Creating an instance of the class ConsoleIO making it equal to the variable input. Note that the method Asking is static.
           var input = ConsoleIO.Asking();
        
            //Uses the class Calculate and the method named CalculateCalories and also uses the user input. Note that the method CalculateCalories is static.
            Calculate.CalculateCalories(input);
        }   
    }
}
