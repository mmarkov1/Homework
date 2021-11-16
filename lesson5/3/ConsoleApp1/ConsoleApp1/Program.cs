using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.   

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string byteFile_name = "bytes.bin";
            string[] massive = Console.ReadLine().Split(' '); //Создаю массив строк, чтобы потом преобразовать его в Byte через цикл
            byte [] mas = new byte[massive.Length];
            for (int i = 0; i < massive.Length; i++) //Создаю цикл, чтобы конвертировать каждый элемент массива строк в массив байт
            {
                mas[i] = Convert.ToByte(massive[i]);
            }
            File.WriteAllBytes(byteFile_name, mas);// Запись в бинарный файл
            Console.ReadLine();

        }
    }
}
