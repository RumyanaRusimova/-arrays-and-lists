using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var virusses = new List<string>();
            int initualStrength = int.Parse(Console.ReadLine());
            int maxHealt = initualStrength;
            var virus = Console.ReadLine();
           
            while(virus != "end")
            {
                int virusStrength = CalculateVirusStrength(virus);
                int virusTime = virusStrength * virus.Length;
                if (virusses.Contains(virus))
                {
                    virusTime = (int)(virusTime / 3.0);
                }
                else
                {
                    virusses.Add(virus);
                }
                initualStrength -= virusTime;
                Console.WriteLine($"Virus {virus}: {virusStrength} => {virusTime} seconds");
                if (initualStrength <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    Console.WriteLine($"{virus} defeated in {CalculateTime(virusTime)}.");
                    Console.WriteLine("Remaining health: " + initualStrength);
                }

                initualStrength = Math.Min(maxHealt, (int)(initualStrength * 1.2));
                virus = Console.ReadLine();
            }
            Console.WriteLine("Final Health: " + initualStrength);
        }

         static int CalculateVirusStrength(string virus)
        {
            int totalStrength = 0;
            for (int i = 0; i < virus.Length; i++)
            {
                totalStrength += virus[i];
            }
            return(int)(totalStrength / 3.0);
        }
        private static string CalculateTime(int time)
        {
            return time / 60 + "m " +  time  %  60 + "s";
        }
    }
}
