using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] ingredients = Console.ReadLine().Split();
            int lenIngr = int.Parse(Console.ReadLine());
            int countIngr = 0;
            var pizza = new List<string>();
            for (int j = 0; j < ingredients.Length && countIngr < 10; j++)
            {
                if (ingredients[j].Length == lenIngr)
                {
                    pizza.Add(ingredients[j]);
                    Console.WriteLine($"Adding {ingredients[j]}.");
                    countIngr++;
                }
            }

            Console.WriteLine($"Made pizza with total of {countIngr} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", pizza)}.");

        }
    }
}


