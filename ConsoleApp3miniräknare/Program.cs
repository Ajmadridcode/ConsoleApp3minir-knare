using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {

            Start:
            Console.WriteLine("Enter first operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second operator: ");
            string op2 = Console.ReadLine();

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number");
            double num3 = Convert.ToDouble(Console.ReadLine());

            string expression = "";

            if (op == "*" || op == "/")
            {
                expression = $"({num1}{op}{num2}){op2}{num3}";
            }
            else
            {
                if (op2 == "*" || op2 == "/")
                {
                    expression = $"({num1}{op2}{num2}){op}{num3}";
                }
                else
                {
                    expression = $"{num1}{op}{num2}{op2}{num3}";
                }

            }

            string sum = new DataTable().Compute(expression, null).ToString();
            Console.WriteLine("expression: " + expression);
            Console.WriteLine("Sum: " + sum);
            
            Console.WriteLine("Press Y to run program again, or 'Enter' to close program");
            string YorN = Console.ReadLine();

            if (YorN == "Y" || YorN == "y")
            {

                goto Start;

            }
            else
            { 
                Environment.Exit(0);

            }
            



        }
    }
}
