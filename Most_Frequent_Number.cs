using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestNum = 0;

            var maxCount = 0; ;
            var currentNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var count = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }


                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestNum = arr[i];
                    }
                }
            }
            Console.WriteLine(bestNum);
        }
    }
}

