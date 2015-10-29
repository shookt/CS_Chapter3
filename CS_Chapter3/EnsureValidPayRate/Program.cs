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
            string rate, rate2, num, num2;
            double pay, pay2, actual, actual2, weeklypay, weeklypay2;
            Console.WriteLine("Enter pay rate");
            rate = Console.ReadLine();
            pay = Convert.ToDouble(rate);
            actual = 5.65;
            actual2 = 49.99;
            num2 = actual2.ToString("C");
            weeklypay = pay * 40;
            num = weeklypay.ToString("C");
            if (pay < actual || pay > actual2)
            {
                Console.WriteLine("Enter pay rate again");
                rate2 = Console.ReadLine();
                pay2 = Convert.ToDouble(rate2);
                weeklypay2 = pay2 * 40;
                if (pay2 < actual || pay2 > actual2)
                {
                    Console.WriteLine("Error");
                }
                else
                    Console.WriteLine("Hourly pay rate is {0} and weekly pay rate is {1}", pay2, weeklypay2);
            }
            else
                Console.WriteLine("Hourly pay rate is {0} and weekly pay rate is {1}", pay, num);
                
        }
    }
}
