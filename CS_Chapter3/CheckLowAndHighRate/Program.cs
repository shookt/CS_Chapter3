using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rate;
            double pay, actual, actual2;
            Console.WriteLine("Enter pay rate");
            rate = Console.ReadLine();
            pay = Convert.ToDouble(rate);
            actual = 5.65;
            actual2 = 49.99;
            if (pay < actual || pay > actual2)
            {
                Console.WriteLine("error");
            }
        }
    }
}