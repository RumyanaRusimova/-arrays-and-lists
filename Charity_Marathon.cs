using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            var lapsPerRunner = int.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            trackCapacity = trackCapacity * days;
            runners = Math.Min(runners, trackCapacity);
            long totalMeters = runners * lapLength * lapsPerRunner;
            long totalKm = totalMeters / 1000;
            double totalMoney = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
