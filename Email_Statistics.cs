using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^([a-zA-Z]{5,})@([a-z]{3,}[.](com|bg|org))$");
            var dict = new Dictionary<string, HashSet<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    
                    string user = match.Groups[1].Value;
                    string domain = match.Groups[2].Value;
                    if (!dict.ContainsKey(domain))
                    {
                        dict[domain] = new HashSet<string>();
                    }
                    if (!dict[domain].Contains(user))
                    {
                        dict[domain].Add(user);
                    }

                }
            }
            foreach (var kvp in dict.OrderByDescending(u => u.Value.Count))
            {
                var domain = kvp.Key;
                Console.WriteLine($"{domain}: ");
                var userNames = kvp.Value.ToList();
                foreach (var userName in userNames)
                {
                    Console.WriteLine($"### {userName}");
                }

            }

        }

    }
}

