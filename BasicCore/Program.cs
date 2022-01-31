using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1 to select Replace String\n" + "Enter 2 to Flip a Coin\n" + "Enter 3 to Check For leap Year\n" + "Enter 4 to exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ReplaceString replaceString = new ReplaceString();
                        replaceString.ReplaceStr();
                        break;
                    case 2:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Toss();
                        break;
                    case 3:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Leap();
                        break;
                    case 4:
                        flag = false;
                        break;

                }
            }
        }
    }
}
