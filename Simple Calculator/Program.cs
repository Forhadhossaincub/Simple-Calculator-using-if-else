using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number #1=? ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Number #2=? ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Operation [+,-, *, /]=? ");
            string op = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Using if..else ..");
            if (op == "+")
            {
                Console.WriteLine($"{n1}+{n2}={n1 + n2}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{n1}-{n2}={n1 - n2}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"{n1}*{n2}={n1 * n2}");
            }
            else if (op == "/")
            {
                Console.WriteLine($"{n1}/{n2}={n1 / n2}");
            }
            else
            {
                Console.WriteLine("Invalid operation");

            }

            Console.ReadKey();



            



        }
    }
}
