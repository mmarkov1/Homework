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
            Console.Write("Введите Фамилию: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите Имя: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine("ФИО: " + GetFullName(firstName, lastName, patronymic));  // Вызываю функцию
            Console.ReadLine();


        }

        static string GetFullName(string firstName, string lastName, string patronymic) 
        {
            return (firstName + " " + lastName + " " + patronymic);  // Сразу в ретерне объединил слова, чтобы было меньше кода
        }
    }
}
