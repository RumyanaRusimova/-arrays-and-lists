using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var line = Console.ReadLine().Split(' ');
            var dic = new Dictionary<string, string>();
            while (line[0] != "END")
            {
                var command = line[0];
                var name = line[1];

                if (command == "A")
                {
                    var number = line[2];
                    if (dic.ContainsKey(name))
                    {
                        dic.Remove(name);
                    }
                    dic.Add(name, number);
                }
                else if (command == "S")
                {
                    if (dic.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} - > {dic[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                line = Console.ReadLine().Split();
            }
        }
    }
}





