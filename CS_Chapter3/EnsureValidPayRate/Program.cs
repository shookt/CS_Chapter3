using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rate, rate2;
            double pay, pay2, actual, actual2, weeklypay;
            Console.WriteLine("Enter pay rate");
            rate = Console.ReadLine();
            pay = Convert.ToDouble(rate);
            actual = 5.65;
            actual2 = 49.99;
            weeklypay = pay * 40;
            if (pay < actual || pay > actual2)
            {
                Console.WriteLine("Enter pay rate again");
                rate2 = Console.ReadLine();
                pay2 = Convert.ToDouble(rate2);
                if (pay2 < actual || pay2 > actual2)
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine(weeklypay);
                
        }
    }
}
