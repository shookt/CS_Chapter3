using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rate;
            double pay, actual;
            Console.WriteLine("Enter pay rate");
            rate = Console.ReadLine();
            pay = Convert.ToDouble(rate);
            actual = 5.65;
            if (pay < actual)
            {
                Console.WriteLine("Go fuck yourself.");
            }
        }
    }
}
