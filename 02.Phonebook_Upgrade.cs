using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dic = new Dictionary<string, string>();

            while (input != "END")
            {
                var line = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = line[0];

                if (command == "A")
                {
                    var name = line[1];
                    var number = line[2];
                    if (!dic.ContainsKey(name))
                    {
                        dic.Add(name, number);
                    }
                    dic[name] = number;
                }
                else if (command == "S")

                {
                    var name = line[1];
                    if  ( !dic.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");                       
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {dic[name]}");
                    }
                }
                else if (command == "ListAll")
                {

                    foreach (var kvp in dic.OrderBy(a => a.Key))
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
                input = Console.ReadLine();
            }
                      
        }

    }
}




