using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var roundedNum = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNum[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);          
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0} => {1}", nums[i], roundedNum[i]);
            }
        }
    }
}
