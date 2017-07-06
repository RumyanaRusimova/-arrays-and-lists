using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();
            int power = 0;
            var result = " ";
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '>')
                {
                    power += int.Parse(path[i + 1].ToString());
                }
                else if (power > 0)
                {
                    power--;
                    continue;
                }
                result += path[i];
            }
            Console.WriteLine(result);
                //    i++;
                 //   while(i< path.Length &&  power > 0)
                //    {
                 //       if (path[i] == '>')
                   //     {
                   //         break;
                   //     }
                  //    path =  path.Remove(i, 1);
                   //     power--;
                   // }
                  //  i--;
               // }
         //   }
          //  Console.WriteLine(path);
        }
    }
}
