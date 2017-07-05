using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();
            var songs = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var participantAwards = new Dictionary<string, SortedSet<string>>();
            var line = Console.ReadLine();
            while(line != "dawn")
            {
                var tokens = line.Split(',')
                    .Select(a => a.Trim())
                    .ToArray();
                var participant = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (songs.Contains(song) && participants.Contains(participant))

                {
                    if (!participantAwards.ContainsKey(participant))
                    {
                        participantAwards[participant] = new SortedSet<string>();
                    }
                    participantAwards[participant].Add(award);

                }
                    line = Console.ReadLine();
              }
                if(!participantAwards.Any())
                    {
                    Console.WriteLine("No awards");
                    return;
                }
                var sortedParticipantsAward = participantAwards.
                    OrderByDescending(a => a.Value.Count)
                    .ThenBy(a => a.Key)
                    .ToDictionary(a => a.Key, a => a.Value);
                foreach(var participantAward in sortedParticipantsAward)
                {
                    var participant = participantAward.Key;

                    var awards = participantAward.Value;
                    Console.WriteLine($"{participant}: {awards.Count} awards");
                    foreach(var award in awards)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }

