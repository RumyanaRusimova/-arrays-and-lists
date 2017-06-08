using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                SwapElements(arr, i, arr.Length - 1 - i);
            }
            Console.WriteLine(string.Join(" ",arr));
        }

        private static void SwapElements(string[]arr, int i, int j)
        {
            var oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }
    }
}
