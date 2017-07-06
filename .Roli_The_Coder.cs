using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)

        {
            var result = new List<Event>();
            var eventsById = new Dictionary<int, Event>();
            while (true)
            {
                //Console.WriteLine("test2");
                var currentLine = Console.ReadLine();
                if (currentLine == "Time for Code")
                {
                    break;
                }
                var lineParts = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var eventId = 0;
                if (!int.TryParse(lineParts[0], out eventId))
                {
                    //Console.WriteLine(currentLine + "c1");
                    continue;
                }
                string eventName = null;
                if (lineParts.Length > 0 && lineParts[1].StartsWith("#"))
                {
                    eventName = lineParts[1].Trim('#');
                }
                else
                {
                    //Console.WriteLine(currentLine + "c2");
                    continue;
                }

                var participants = new List<string>();
                
                if (lineParts.Length > 2)
                {
                    participants = lineParts.Skip(2).ToList();
                    //Console.WriteLine("participants: " + String.Join(", ", participants));
                    
                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        //Console.WriteLine(currentLine + "c3");
                        continue;
                    }
                }
                if (eventsById.ContainsKey(eventId))
                {
                    if (eventsById[eventId].Name == eventName)
                    {
                        var existingEvent = eventsById[eventId];
                        foreach(var participant in participants)
                            {
                            if(!existingEvent.Participants.Contains(participant))
                            {
                                existingEvent.Participants.Add(participant);
                            }
                        }
                       
                    }
                    else
                    {
                        //Console.WriteLine(currentLine + "c4");
                        continue;
                    }
                }
                else
                {
                    var newEvent = new Event

                    {
                        Id = eventId,
                        Name = eventName,
                        Participants = participants

                    };
                    result.Add(newEvent);
                    eventsById.Add(eventId, newEvent);
                }
                //Console.WriteLine("test");
            }

                var sortedEvents = result
                    .OrderByDescending(e => e.Participants.Count)
                    .ThenBy(e => e.Name);
           // Console.WriteLine("sortedEventsSize " + sortedEvents.Count());
                foreach (var ev in sortedEvents)
                {
                    var distinctParticipants = ev.Participants.Distinct().ToList();
                    Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");

                    foreach (var participant in distinctParticipants.OrderBy(p => p))
                    {
                        Console.WriteLine(participant);
                    }
                }
            }
        }
    }




