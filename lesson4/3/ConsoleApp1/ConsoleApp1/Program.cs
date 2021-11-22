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
            Console.Write("Введите число месяца (от 1 до 12): ");
            int number = Convert.ToInt32(Console.ReadLine()); // Подается число
            Console.WriteLine(Season(number));
            Console.ReadLine();
        }

        static string Season(int number) 
        {
            if (3 == number || number == 5 || number == 4)       return "Сейчас Весна (Spring)";
            else if (6 == number || number == 8 || number == 7)  return "Сейчас Лето (Summer)";    
            else if (9 == number || number == 11 & number == 10) return "Сейчас Осень (Autumn)";
            else if (number == 12 || number == 1 || number == 2) return "Сейчас Зима (Winter)";            
            else                                                 return "Ошибка, введите число от 1 до 12";
        }
    }
}
