using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine().ToCharArray();
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
                            
            
                for (int j = 0; j < letters.Length; j++)
                {
                    for (int i = 0; i < arr.Length; i++)
                     { 
                        if (arr[i] == letters[j])
                         {
                        Console.WriteLine(arr[i] +  " -> "  + i);
                         }                   
                }
            }
        }
    }
}
    
