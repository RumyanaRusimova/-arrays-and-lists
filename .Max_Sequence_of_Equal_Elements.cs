using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bestIndex = 0;
            var longestLenght = 0;
            var currentStartIndex = 0; 
            var currentLenght = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {

                    currentLenght++;
                    if (currentLenght > longestLenght)
                    {
                        longestLenght = currentLenght;

                        bestIndex = currentStartIndex;
                    }
                }
                else                                  
                    
                    {
                        currentStartIndex = i;
                        currentLenght = 1;
                    }
                }                     

                for (int i = bestIndex; i < bestIndex + longestLenght; i++)
                {
                    Console.Write ( arr[i] + " " );
                }
            }          
           
        }
  
    }

