using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var filteredArray = initialArray.Where(a => a % 2 == 0).ToArray();
            var finalArray = filteredArray
                .Select(a => a > filteredArray.Average() ? ++a : --a)
                .ToArray();
            Console.WriteLine(string.Join(" ",finalArray));


        }
    }
}
