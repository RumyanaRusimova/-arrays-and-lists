using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            var newNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {            
                char[] CharAr = nums[i].ToCharArray();
                char[] reversed = CharAr.Reverse().ToArray();        
           
                newNums.Add(int.Parse(string.Join("",reversed)));
            }
         //   int sum = Console.ReadLine().Split().Select(e => new string(e.Reverse().ToArray())).Sum(e => int.Parse(e));
         //   Console.WriteLine(sum);
            Console.WriteLine(newNums.Sum());
        }            
            
    }
}

