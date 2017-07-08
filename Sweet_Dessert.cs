using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            long numberOfGuest = long.Parse(Console.ReadLine());
            decimal priceOfBanana = decimal.Parse(Console.ReadLine());
            decimal priceOfEgg = decimal.Parse(Console.ReadLine());
            decimal priceOfBerriesForKilo = decimal.Parse(Console.ReadLine());

            long guestCount = (long)Math.Ceiling(numberOfGuest / 6.0);

            decimal priceForAll = (2 * priceOfBanana + 4 * priceOfEgg + 0.2m * priceOfBerriesForKilo) * guestCount;
            if(priceForAll <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceForAll:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(priceForAll - amountOfCash):F2}lv more.");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _e
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            long numberOfGuest = long.Parse(Console.ReadLine());
            decimal priceOfBanana = decimal.Parse(Console.ReadLine());
            decimal priceOfEgg = decimal.Parse(Console.ReadLine());
            decimal priceOfBerriesForKilo = decimal.Parse(Console.ReadLine());

            long guestCount = (long)Math.Ceiling(numberOfGuest / 6.0);

            decimal priceForAll = (2 * priceOfBanana + 4 * priceOfEgg + 0.2m * priceOfBerriesForKilo) * guestCount;
            if(priceForAll <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceForAll:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(priceForAll - amountOfCash):F2}lv more.");
            }
        }
    }
}
