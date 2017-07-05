using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _2.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {

            var key = Console.ReadLine();
            var sentences = Console.ReadLine();
            var pattern = @"[^\!\.\?]*\b" + key + @"\b[^\!\.|?]*";
            var matches = Regex.Matches(sentences, pattern);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}

