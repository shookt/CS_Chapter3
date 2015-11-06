using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, input2;
            double pay, hours, gross, withhold, net;
            Console.WriteLine("Input your hourly pay rate.");
            input = Console.ReadLine();
            pay = Convert.ToDouble(input);
            Console.WriteLine("Input the amount of hours you work.");
            input2 = Console.ReadLine();
            hours = Convert.ToDouble(input2);
            gross = pay * hours;
            withhold = 0;
            if (gross <= 300)
            withhold = withhold + .10;
            else if (gross > 300)
                withhold = withhold + .12;
            net = gross - (withhold * gross);
            Console.WriteLine(gross);
            Console.WriteLine(withhold);
            Console.WriteLine(net);
        }
    }
}
