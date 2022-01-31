using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the year\n");
            string input = Console.ReadLine();
            if (input.Length != 4)
               {
                  Console.WriteLine("Enter The COrrect Year\n");
                }
            else
               {
                  int year = Convert.ToInt32(input);
                  if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                     {
                        Console.WriteLine("Yes!! It is a Leap Year\n");
                     }
                  else
                     {
                        Console.WriteLine("No!! It is  not a Leap Year\n");
                     }
               }
        }
    }
}
