using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();
            var startIndex = 0;
            var endIndex = 0;
            while((startIndex = path.IndexOf("<"))!= -1 &&( endIndex = path.IndexOf(">"))!= -1)
                {
               var bombChars = path.Substring(startIndex + 1, 2);
                var bombStrenght = CalculateMineStr(bombChars);
                var leftFromTheBomb = Math.Max(0,startIndex - bombStrenght);
                var rightFromTheBomb = Math.Min(path.Length - 1, endIndex + bombStrenght);
                var sb = new StringBuilder(path);
                for (int i = leftFromTheBomb; i <= rightFromTheBomb; i++)
                {
                    sb[i] = '_';
                }
                path = sb.ToString();                
            }
            Console.WriteLine(path);
        }

        private static int CalculateMineStr(string bombChars)
        {
            return Math.Abs(bombChars[0] - bombChars[1]);
        }
    }
}
