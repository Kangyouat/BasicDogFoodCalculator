using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogFoodCalculator.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            SetUpWorkflow setUp = new SetUpWorkflow();

            setUp.Start();
        }
    }
}
