using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, input2;
            double num, num2;
            Console.WriteLine("Enter your GPA.");
            input = Console.ReadLine();
            Console.WriteLine("Enter your test score.");
            input2 = Console.ReadLine();
            num = Convert.ToDouble(input);
            num2 = Convert.ToDouble(input2);
            if (num >= 3.0 && num2 >= 60)
                Console.WriteLine("Accept.");
            else if (num < 3.0 && num2 >= 80)
                Console.WriteLine("Accept.");
            else
                Console.WriteLine("Reject.");
        }
    }
}
