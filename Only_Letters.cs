using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(\d+)+([a-zA-Z])");
            var text = Console.ReadLine();
            var matches = regex.Matches(text);
            foreach(Match m in matches)
            {
                var num = m.Groups[1].Value;
                var letter = m.Groups[2].Value;
                text = text.Replace(num, letter);
            }          
            
            Console.WriteLine(text);

        }
    }
}
