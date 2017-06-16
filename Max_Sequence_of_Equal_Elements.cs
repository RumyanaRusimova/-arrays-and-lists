using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxSeq = FindMazSequenceOfEqualElements(arr);
            Console.WriteLine(string.Join(" ", maxSeq));
        }

        private static int[] FindMazSequenceOfEqualElements(int[] arr)
        {
            var longestSeq = new List<int>();
            var currentSeq = new List<int>();
            currentSeq.Add(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var searchNum = currentSeq[0];
                if (currentNum == searchNum)
                {
                    currentSeq.Add(currentNum);
                }
                else
                {
                    if (currentSeq.Count > longestSeq.Count)
                    {
                        longestSeq = new List<int>(currentSeq);
                    }
                    currentSeq.Clear();
                  //  currentSeq = new List<int>();
                    currentSeq.Add(currentNum);
                }
            }

            if (currentSeq.Count > longestSeq.Count)
            {
                longestSeq = new List<int>(currentSeq);
            }
            return longestSeq.ToArray();
        }
    }
}
