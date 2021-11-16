using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentTime = DateTime.Now.TimeOfDay.ToString();
            string filename = "startup.txt";
            File.AppendAllLines(filename, new[] { currentTime });  //Дописывает текущее время в новую строку в файле, а не переписывает сам файл
            Console.ReadLine();
        }
    }
}
