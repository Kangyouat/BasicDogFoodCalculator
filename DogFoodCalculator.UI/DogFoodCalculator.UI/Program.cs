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
            //Creating an instance of a class called SetUpWorkflow
            SetUpWorkflow setUp = new SetUpWorkflow();

            //Using the class SetUpWorkflow by using the variable setUp and then using its method called Start
            setUp.Start();
        }
    }
}
