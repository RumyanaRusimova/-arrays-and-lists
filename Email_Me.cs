using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Email_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            int index = email.IndexOf('@');
            var name = email.Substring(0, index);
            var domein = email.Substring(index +1);
            int sumName = 0;
            foreach(var symbol in name)
            {
                sumName += (int)symbol;
            }
            int sumDomein = 0;
            foreach(var symbol in domein)
            {
                sumDomein += (int)symbol;
            }
            int result =  sumName - sumDomein;
            if (result >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
      
        }
    }
}
