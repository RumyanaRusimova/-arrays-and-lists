using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Where(x => x.Length == 2).ToList();
     var result = new List<char>();
            for (int i = 0; i < list.Count; i++)
            {

                char[]arr = list[i].ToCharArray();
                Array.Reverse(arr);
                list[i] = new string(arr);
            
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                var element = list[i];
               var converted = Convert.ToUInt32(element,16);
                char charact = (char)converted;
                result.Add(charact);
            }
            Console.WriteLine(String.Join("", result));
     
              
               
        }
    }
}
