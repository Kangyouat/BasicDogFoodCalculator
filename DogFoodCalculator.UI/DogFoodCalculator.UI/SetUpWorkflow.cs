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
           var input = ConsoleIO.Asking();
        
            Calculate.CalculateCalories(input);
        }   
    }
}
