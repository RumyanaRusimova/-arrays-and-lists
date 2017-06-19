using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var line = Console.ReadLine();
            while(line != "print")
            {
                var tokens = line.Split();
                var command = tokens[0];
                if (command == "add")
                {
                    var index = int.Parse(tokens[1]);
                    var element = int.Parse(tokens[2]);
                   
                    list.Insert(index, element);
                }
                else if (command == "addMany")
                {
                    var index = int.Parse(tokens[1]);
                    //   var elements = tokens.Skip(2).ToArray();
                    var elements = new List<int>();
                    for (int i = 2; i < tokens.Length ; i++)
                    {
                        var currentItem = int.Parse(tokens[i]);
                         elements.Add(currentItem);
                    }
                    list.InsertRange(index, elements);

                }
                else if (command == "contains")
                {
                    var element = int.Parse(tokens[1]);
                    var index = list.IndexOf(element);
                  // var index = -1;                   
                  //  if (list.Contains(element))
                 //   {
                  //      for (int i = 0; i < list.Count; i++)
                   //     {
                     //       if (list[i] == element)
                      //      {
                       //         index = i;
                       //         break;
                       //     }
                     //   }
                 //   }
                    Console.WriteLine(index);

                }
                else if (command == "remove")
                {
                    var index = int.Parse(tokens[1]);
                    list.RemoveAt(index);
                }
                else if (command == "shift")
                {
                    var count = int.Parse(tokens[1]) % list.Count;
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (command == "sumPairs")
                {
                    var pairsSum = new List<int>();
                    for (int i = 0; i < list.Count ; i+= 2)
                    {
                        var currentElem = list[i];
                        var nextElem = 0;
                        if (i < list.Count- 1)
                        {
                            nextElem = list[i + 1];
                        }
                        var elementsSum = currentElem + nextElem;
                        pairsSum.Add(elementsSum);
                    }
                    list = pairsSum;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("[" +string.Join(", ", list)   +"]");

        }
    }
}
