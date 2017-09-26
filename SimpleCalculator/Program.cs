using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

            
            Console.Write("Enter an expression: ");

            string expression = Console.ReadLine();

            string[] exp = expression.Split(' ');

            int solution;
            if (exp[1] == "+")
            {
                solution = Convert.ToInt32(exp[0]) + Convert.ToInt32(exp[2]);

                Console.WriteLine("Result: " + expression + " = " + solution);
            }

            if (exp[1] == "-")
            {
                solution = Convert.ToInt32(exp[0]) - Convert.ToInt32(exp[2]);

                Console.WriteLine("Result: " + expression + " = " + solution);
            }

            if (exp[1] == "*")
            {
                solution = Convert.ToInt32(exp[0]) * Convert.ToInt32(exp[2]);

                Console.WriteLine("Result: " + expression + " = " + solution);
            }

                if (exp[1] == "/")
                {
                    solution = Convert.ToInt32(exp[0]) / Convert.ToInt32(exp[2]);

                    Console.WriteLine("Result: " + expression + " = " + solution);
                }
            }
        }
    }
}
