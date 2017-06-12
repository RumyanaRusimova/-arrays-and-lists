using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            string[] command = Console.ReadLine().Split(' ');
            while ( command[0] !="END")
            {
               switch(command[0])
                {
                    
                    case "Distinct":
                        text = text.Distinct().ToArray();
                        break;
                    case "Reverse":
                        text = text.Reverse().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index >= text.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            text[index] = command[2];
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!"); 
                            break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", text));
        }
    }
}
