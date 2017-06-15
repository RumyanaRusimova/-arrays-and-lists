using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            long sum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {

                if (nums[i] != n)
                {
                    counter++;
                }
                //   int newPoc = Array.LastIndexOf(nums, n);
                if (nums[i] == n)
                {
                    break;
                }
            }
                if (counter == nums.Length)
                {
                    Console.WriteLine("No occurrences were found!");
                }
                else
                {
                    for (int i = 0; i < nums.Length - 1 - counter; i++)
                    {
                        sum += nums[i];
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }

