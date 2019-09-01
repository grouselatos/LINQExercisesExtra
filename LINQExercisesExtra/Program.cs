using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercisesExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Queries samples = new Queries();

            //Hands - on exercises
            samples.FindFirstElement();
            samples.FindOutOfStock();
            samples.NumbersOfTypeDouble();
            samples.CheckIfAnyBeverages();

            //Home exercises
            samples.ProductWithId7();
            samples.CountProductsUnderPriceTen();
            samples.CheckAllProductsInStock();


            //Sleep for 60 seconds
            System.Threading.Thread.Sleep(60000);
            Console.ReadKey();

        }

        
    }
}
