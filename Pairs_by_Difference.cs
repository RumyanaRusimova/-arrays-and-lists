using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var diff = int.Parse(Console.ReadLine());
            var countPairs = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if ((arr[i] - arr[j]) == diff)
                    {
                        countPairs++;
                    }
                }
            }
            Console.WriteLine(countPairs);
        }
    }
}
