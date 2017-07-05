using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _1.Sino_The_Walker
{
    class Program
    {
      //  public static DateTime date;
        
        static void Main(string[] args)
        {
            var timeFormat = @"hh\:mm\:ss";
            var livingTime = TimeSpan.ParseExact(Console.ReadLine(),timeFormat, CultureInfo.InvariantCulture);
            var stepsNeeded = decimal.Parse(Console.ReadLine());
            var secondsPerStep = decimal.Parse(Console.ReadLine());
            var secundInAnDay = 60 * 60 * 24;
            int totalSecondsNeeded = (int)(stepsNeeded * secondsPerStep % secundInAnDay);

            TimeSpan totalSecondsNeededTimeSpan = new TimeSpan(0, 0, 0, totalSecondsNeeded);
            var arrivalTime = livingTime.Add(totalSecondsNeededTimeSpan);          

           // var arrivalTime = livingTime.Add(new TimeSpan(0, 0, totalSecondsNeeded));
            Console.WriteLine("Time Arrival: " + arrivalTime.ToString(timeFormat));
         //   string hour = timeInSoftuni.Substring(0, 2);
         //   string min = timeInSoftuni.Substring(3, 2);
         //   string sec = timeInSoftuni.Substring(6, 2);
         //   int hours = int.Parse(hour);
         //   int minutes = int.Parse(min);
          //  int secundes = int.Parse(sec);

        // TimeSpan span = new TimeSpan(hours, minutes, secundes);
          
           // TimeSpan span2 = new TimeSpan(0, 0, timeToGo);
            //TimeSpan total = span + span2;

         // Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}",total);                                   
                
         //  DateTime date = DateTime.ParseExact(timeInSoftuni, "HH:mm:ss", CultureInfo.InvariantCulture);
          //  date = date.AddSeconds(timeToGo);
          //  Console.Write("Time Arrival: ");
          //  Console.WriteLine((date.ToString("HH:mm:ss")));
        }
       }
    }


