using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split();
            var quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var product = Console.ReadLine();
            while (product != "done")
            {
                var tokens = product.Split(' ');
                var currentProduct = tokens[0];
                var quantityOrder = long.Parse(tokens[1]);

                for (int i = 0; i < products.Length; i++)

                {
                    if (tokens[0] == products[i])
                    {
                        int index = Array.IndexOf(products, tokens[0]);
                        long goodsStock =
                     index < quantity.Length ?
                     quantity[index] :
                     0;
                        if (goodsStock >= quantityOrder)
                        {
                            var totalPrice = quantityOrder * price[index];
                            Console.WriteLine($"{products[index]} x {quantityOrder} costs {totalPrice:F2}");
                            quantity[index] -= quantityOrder;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {products[index]}");
                        }


                        product = Console.ReadLine();
                    }
                }
            }
        }
    }
}

    



 
