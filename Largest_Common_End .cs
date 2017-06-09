using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine().Split(' ').ToArray();
            var str2 = Console.ReadLine().Split(' ').ToArray();
            int min = Math.Min(str1.Length, str2.Length);
            int leftCount = 0;
            int rightCount = 0;
           
            for (int i = 0; i < min; i++)
            {
                if(str1[i] == str2[i])
                {
                    leftCount++;
                }
                if (str1[str1.Length - 1 - i] == str2[str2.Length - 1 - i])
                {
                    rightCount++;
                }
            }

            //int firstStartIndex = str1.Length-1;
           //int  secondStartIndex = str2.Length-1;
            //for (int i = min; i > 0; i--)
            //{

                //if(str1[firstStartIndex] == str2[secondStartIndex])
            //    {
            //        rightCount++;
            //    }
            //    --firstStartIndex;
            //    --secondStartIndex;
            //}
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}
