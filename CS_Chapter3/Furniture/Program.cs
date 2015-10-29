using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, pricep, priceo, pricem;
            double p, o, m;
            p = 100;
            o = 225;
            m = 310;
            pricep = p.ToString("C");
            priceo = o.ToString("C");
            pricem = m.ToString("C");
            Console.WriteLine("Price of pine is {0}.", pricep);
            Console.WriteLine("Price of oak is {0}.", priceo);
            Console.WriteLine("Price of mahogany is {0}.", pricem);
            Console.WriteLine("What wood do you want? 'P' for pine, 'O' for oak, 'M' for mahogany.");
            input = Console.ReadLine();
            if (input == "P")
                Console.WriteLine(pricep);
            if (input == "O")
                Console.WriteLine(priceo);
            if (input == "M")
                Console.WriteLine(pricem);
            else
                Console.WriteLine("the price is $0");
        }
    }
}
