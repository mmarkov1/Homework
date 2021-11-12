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
            Console.Write("Введите числа через пробел: ");
            string[] massive = (Console.ReadLine().Split(' ')); // Пользователь вводит только числа, но используем строку, чтобы потом в методе ее преобразовать в число
            Console.WriteLine(PlusAll(massive));
            Console.ReadLine();
        }

        static string PlusAll(string[] massive) 
        {
            int sum = 0;
            int check = 0; //Нужно для проверки числа на знаки
            for (int i = 0; i < massive.Length; i++) 
            {
                int number = 0;
                bool canConvert = int.TryParse(massive[i], out number); // Проверка на то, что все знаки являются числами
                if (canConvert == true) // Если проверка удалась, цикл идет дальше
                {
                    int num = Int32.Parse(massive[i]); // По условию сказано, что пользователь вводит набор чисел
                    sum += num;
                }
                else // Если не удалась, цикл обрывается
                {
                    check = 1;
                    break;
                }
            }
            if (check == 0) return Convert.ToString(sum); //конвертируюется в строку
            else return "В списке есть не число";
        }
    }
}
