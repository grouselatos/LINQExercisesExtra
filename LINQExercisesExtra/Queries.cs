using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercisesExtra
{
    public class Queries
    {
        private List<Product> products;

        public Queries()
        {
            products = new List<Product> {
                    new Product { ProductID = 1, ProductName = "Coffe Espresso", Category = "Beverages", UnitPrice = 10.0000M, UnitsInStock = 29 },
                    new Product { ProductID = 2, ProductName = "Coffe Espresso Premium", Category = "Beverages", UnitPrice = 12.0000M, UnitsInStock = 18 },
                    new Product { ProductID = 3, ProductName = "Great Biscuits", Category = "Sweets", UnitPrice = 2.0000M, UnitsInStock = 33 },
                    new Product { ProductID = 4, ProductName = "Salt", Category = "Condiments", UnitPrice = 1.5000M, UnitsInStock = 50 },
                    new Product { ProductID = 5, ProductName = "Pepper Mix", Category = "Condiments", UnitPrice = 2.7500M, UnitsInStock = 0 },
                    new Product { ProductID = 6, ProductName = "Choco Cereal", Category = "Cereal", UnitPrice = 3.5000M, UnitsInStock = 20 },
                    new Product { ProductID = 7, ProductName = "Fresh Pears", Category = "Produce", UnitPrice = 7.0000M, UnitsInStock = 15 },
                    new Product { ProductID = 8, ProductName = "Fresh Orange Juice", Category = "Beverages", UnitPrice = 2.0000M, UnitsInStock = 26 },
                    new Product { ProductID = 9, ProductName = "Chicken", Category = "Meat", UnitPrice = 9.0000M, UnitsInStock = 19 },
                    new Product { ProductID = 10, ProductName = "Perch Fish", Category = "Seafood", UnitPrice = 25.0000M, UnitsInStock = 11 },
                };
        }

        public void FindFirstElement()
        {
            //TODO: Implement. Print the output in console.
            var firstel = products.FirstOrDefault();

            if(firstel != null)
            {

                Console.WriteLine(firstel);
            }
        }

        public void FindOutOfStock()
        {
            //TODO: Implement. Print the output in console.
            var outofstock = products.Where(x => x.UnitsInStock == 0);
            foreach (var item in outofstock)
            {
                Console.WriteLine(item);
            }
        }

        public void ProductWithId7()
        {
            //TODO: Implement. Print the output in console.
            var product7 = products.Where(x => x.ProductID == 7).FirstOrDefault();
            var result = products.FirstOrDefault(x => x.ProductID == 7);
            var result1 = products.SingleOrDefault(x => x.ProductID == 7); // better way because it throws exception if there is more than one unique IDs
            var result2 = products.Find(i => i.ProductID == 7); // better query when you search in database, the one above is better for RAM memory

            if(product7 != null)
            {
                Console.WriteLine(product7);
            }
        }

        public void CountProductsUnderPriceTen()
        {
            //TODO: Implement. Print the output in console.
            var result = products.Where(x => x.UnitPrice < 10).Count();
            var result2 = products.Count(x => x.UnitPrice < 10); // same thing, shorter code

            Console.WriteLine(result2);
        }

        public void NumbersOfTypeDouble()
        {
            //TODO: Implement. Print the output in console.
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "seven", 10.0 };

            var objdouble = numbers.OfType<double>();
            var objdouble1 = numbers.Where(i => i is double).Cast<double>();

            Console.WriteLine(objdouble);
            Console.WriteLine(objdouble1);
        }

        public void CheckIfAnyBeverages()
        {
            //TODO: Implement. Print the output in console.
            var beverages = products.Any(i => i.Category == "Beverages"); // returns True/False

            Console.WriteLine(beverages);
        }

        public void CheckAllProductsInStock()
        {
            //TODO: Implement. Print the output in console.
            var productsinstock = products.All(i => i.UnitsInStock > 0); // returns True/False

            Console.WriteLine(productsinstock);
        }
    }
}
