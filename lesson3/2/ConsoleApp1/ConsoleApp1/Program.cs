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
            string[,] numbook = new string[5, 2]; // Создается массив, 5 строк, 2 слова
            for (int i = 0; i < numbook.GetLength(0); i++) //Цикл для ввода имени и номера
            {
                Console.WriteLine("Введите имя " + (i + 1) + " контакта");
                numbook[i, 0] = Console.ReadLine();
                Console.WriteLine("Введите номер или емейл " + (i + 1) + " контакта");
                numbook[i, 1] = Console.ReadLine();
            }
            for (int i = 0; i < numbook.GetLength(0); i++) // Показ того, что ввели
            {
                Console.Write("Контакт " + (i + 1) + ": " + numbook[i, 0] + " : " + numbook[i, 1]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
