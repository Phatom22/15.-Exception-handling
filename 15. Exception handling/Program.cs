using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter your first number");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter second number");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("your answer is = ");
                Console.Write(number1 / number2);
            }
            catch
            {
                Console.WriteLine(" ERROR!! INVALID INPUT");
            }
            Console.ReadLine();
        }
    }
}
