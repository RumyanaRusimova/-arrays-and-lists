using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Reverse":
                        arr = arr.Reverse().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(commands[1]);
                        arr[index] = commands[2];
                        break;
                }
            }
       
           
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
