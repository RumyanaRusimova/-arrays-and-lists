using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {

          //  ((daysInMonth * capsulesCount) * pricePerCapsule)
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());
                decimal currentPricePerCapsule = (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount)
                    * pricePerCapsule;

                Console.WriteLine("The price for the coffee is: ${0:F2}",currentPricePerCapsule);
                 totalPrice += currentPricePerCapsule;
            }
           
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
