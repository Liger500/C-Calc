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

            String choice;
            int x = 0;
            int y = 0;
            int z = 0;
            String A = "A";
            String B = "B";
            String C = "C";
            String D = "D";

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("A) Add");
            Console.WriteLine("B) Subtract");
            Console.WriteLine("C) Multiply");
            Console.WriteLine("D) Divide");
            choice = Console.ReadLine();

            Console.WriteLine("Please enter the first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine("Please enter the second number:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y);

            if (choice == A)
            {
                z = x + y;
            }
            if (choice == B)
            {
                z = x - y;
            }
            if (choice == C)
            {
                z = x * y;
            }
            if (choice == D)
            {
                z = x / y;
            }


            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
