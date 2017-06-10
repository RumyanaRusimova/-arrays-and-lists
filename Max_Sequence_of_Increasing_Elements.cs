using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currentStartIndex = 0;
            var bestIndex = 0;
            var currentSeq = 1;
            var maxSeq = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentSeq++;
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        bestIndex = currentStartIndex;
                    }
                 }
                else
                {
                    currentSeq = 1;
                    currentStartIndex = i;
                }
            }
            for (int i = bestIndex; i < bestIndex + maxSeq; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
