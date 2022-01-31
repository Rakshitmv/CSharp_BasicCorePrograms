using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class PowerOf2
    {
        public void Power2()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            long pow = 1;
            for (int i = 1; i <= num; i++)
            {
                 pow *= 2;
            }

            Console.WriteLine($"2^{num} = " + pow);
        }
    }
}
