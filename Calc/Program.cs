using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int y = 0;
            int result = 0;
            string symbol;

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("+) Add");
            Console.WriteLine("-) Subtract");
            Console.WriteLine("*) Multiply");
            Console.WriteLine("/) Divide");
            symbol = Console.ReadLine();

            Console.WriteLine("Please enter the first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine("Please enter the second number:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y);

            if (symbol == "+")
            {
                result = Add(x, y);
            }
            if (symbol == "-")
            {
                result = Sub(x, y);
            }
            if (symbol == "*")
            {
                result = Mult(x, y);
            }
            if (symbol == "/")
            {
                result = Div(x, y);
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }  //End main

        static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }  //End Add
        static int Sub(int x, int y)
        {
            int result = x - y;
            return result;
        }  //End Sub
        static int Mult(int x, int y)
        {
            int result = x * y;
            return result;
        }
        static int Div(int x, int y)
        {
            int result = x / y;
            return result;
        }
    }  //End class
}  //End namespace
