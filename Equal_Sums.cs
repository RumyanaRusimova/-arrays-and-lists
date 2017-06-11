using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var leftSum = 0;
            var rightSum = 0;
            var countLeftSum = 0;
            var check = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                    countLeftSum++;
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(countLeftSum);
                    check++;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
                countLeftSum = 0;
            }
            if (check == 0)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
