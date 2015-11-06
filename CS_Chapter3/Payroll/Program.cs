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

            // Get the hourly pay rate from the user
            Console.Write("Input your hourly pay rate: ");
            input = Console.ReadLine();
            pay = Convert.ToDouble(input);
            
            // Now find out how many hours they worked
            Console.Write("Input the hours you work: ");
            input2 = Console.ReadLine();
            hours = Convert.ToDouble(input2);

            Console.WriteLine();
            
            // Calculate gross and net pay
            gross = pay * hours;
            withhold = 0;
            if (gross <= 300)
                withhold = gross * 0.10;
            else if (gross > 300)
                withhold = gross * 0.12;
            net = gross - withhold;


            // Display output to the user
            Console.WriteLine("Gross Pay:       " + gross.ToString("C").PadLeft(10));
            Console.WriteLine("Withholding Tax: " + withhold.ToString("C").PadLeft(10));
            Console.WriteLine("Net Pay:         " + net.ToString("C").PadLeft(10));
        }
    }
}
