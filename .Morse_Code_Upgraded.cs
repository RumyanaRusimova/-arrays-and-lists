using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputCodes = Console.ReadLine()
                .Split('|');
            var message = string.Empty;

            foreach (var code in inputCodes)
            {
                var sum = 0;
                var matches = Regex.Matches(code, @"([\d])(\1+)?");
                foreach (Match match in matches)
                {
                    var matchStr = match.Value;
                    sum += matchStr.Length > 1 ?
                        matchStr.Length :
                        0;
                    sum += matchStr.StartsWith("0") ?
                        matchStr.Length * 3 :
                        matchStr.Length * 5;
                }
                message += (char)sum;
            }

            Console.WriteLine(message);
        
        }
    }
}
