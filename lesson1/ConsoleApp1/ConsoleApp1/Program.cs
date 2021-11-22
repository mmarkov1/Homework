using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
//Имя пользователя сохранить из консоли в промежуточную переменную.
//Поставить точку останова и посмотреть значение этой переменной в режиме отладки. Запустить исполняемый файл через системный терминал.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше Имя: ");
            string nameUser = Console.ReadLine();
            Console.WriteLine("Привет, " + nameUser + ", сегодня " + DateTime.Now);
            Console.ReadLine();
        }
    }
}
