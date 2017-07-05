using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pattern = @"([$#^@])\1{5,}";
            Regex regex = new Regex(pattern);
            var tickets = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var leftHalf = ticket.Substring(0, ticket.Length / 2);
                var rightHalf = ticket.Substring(ticket.Length / 2);
                var leftMatch = regex.Match(leftHalf);
                var rightMatch = regex.Match(rightHalf);
                if (leftMatch.Success && rightMatch.Success)
                {
                    var winningSymbol = leftMatch.Value[0];
                    var shorterMatch = Math.Min(leftMatch.Length, rightMatch.Length);
                    var jackpot = string.Empty;
                    if (shorterMatch == 10)
                    {
                        jackpot = "Jackpot!";
                    }
                    Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{winningSymbol} {jackpot}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}

