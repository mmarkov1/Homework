using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string filename = "text_file.txt";
            File.WriteAllText(filename, text);
            Console.ReadLine();
        }
    }
}
