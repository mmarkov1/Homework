using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите порядковый номер числа Фибоначчи: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fib(number));
            Console.ReadLine();
        }

        static int Fib(int number) 
        {
            if (number == 0 || number == 1) return number;
            return Fib(number - 1) + Fib(number - 2);
        }
    }
}
