using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
//Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
//В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            int temp = 0; // Нужно чтобы выйти из бесконечного цикла do while
            do { // Цикл нужен для того, чтобы не перезапускать программу из-а неправильного ввода, программа просто предложит заного ввести
                Console.WriteLine("Что хотите сделать? Введите цифру");
                Console.WriteLine("1) Ввод ID процесса и завершить его");
                Console.WriteLine("2) Ввод Имени процесса и завершить его");
                Console.WriteLine("3) Отобразить список процессов");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": // Выбор по ID процесса
                        Console.WriteLine("Введите ID процесса, который нужно завершить");
                        int number;
                        string num = Console.ReadLine();
                        bool result = int.TryParse(num, out number); // Нужно для проверки на число, если не число, ввод повторится 
                        if (result == true)
                        {
                            try
                            {
                                Process proc = Process.GetProcessById(Convert.ToInt32(num)); 
                                try
                                {
                                    proc.Kill();
                                    Console.WriteLine("Процесс удален");
                                }
                                catch
                                {
                                    Console.WriteLine("Произошла ошибка, данный процесс остановить нельзя, программа будет завершена");
                                }
                            }
                            catch (System.ArgumentException)
                            {
                                Console.WriteLine("Нет Процесса с этим ID, программа завершится");
                            }
                            temp = 1; // Программа завершится
                        }
                        else 
                        {
                            Console.WriteLine("Введено не число, попробуйте снова");
                            Console.WriteLine();
                        }
                        break;



                    case "2": // Выбор по имени процесса
                        Console.WriteLine("Введите Имя процесса");
                        Process[] procc = Process.GetProcessesByName(Console.ReadLine()); // Так как с именем может быть больше 1 процесса, придется выбирать, завершить все процессы или только 1
                        if (procc.Length == 1) // Если процесс 1 найден с таким именем  
                        {   try
                            {
                                procc[0].Kill();
                                Console.WriteLine("Процессов с этим именем 1, и оно было завершено");
                            }
                            catch 
                            {
                                Console.WriteLine("Произошла ошибка, программа будет завершена");
                            }
                        }
                        else if (procc.Length > 1) // Если процессов больше чем 1 с таким именем
                        {
                            Console.WriteLine("Cписок процессов с этим именем");
                            for (int i = 0; i < procc.Length; i++) // Показ ID и имени процесса
                            {
                                Console.Write("ID: " + procc[i].Id);
                                Console.WriteLine(" | Proc.Name: " + procc[i].ProcessName);
                                Console.WriteLine();
                            }
                            int tem = 0;
                            do // Цикл, в котором есть выбор, либо завершить все процессы с данным именем, либо только 1 программу через ID
                            {
                                Console.WriteLine("Введите");
                                Console.WriteLine("1) ID Процесса, чтобы его завершить");
                                Console.WriteLine("2) all Чтобы завершить все процессы");
                                string ch = Console.ReadLine();
                                Console.WriteLine();
                                for (int i = 0; i < procc.Length; i++)
                                {
                                    if (ch == "all") // Удаление всего
                                    {
                                        try
                                        {
                                            procc[i].Kill();
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Произошла ошибка, программа будет завершена");
                                            tem = 1;
                                            break;
                                        }
                                        Console.WriteLine("Процесс удален");
                                        tem = 1;
                                    }
                                    else if (ch == Convert.ToString(procc[i].Id)) // Удаление только 1 процесса
                                    {
                                        try
                                        {
                                            procc[i].Kill();
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Произошла ошибка, программа будет завершена");
                                            tem = 1;
                                            break;
                                        }
                                        Console.WriteLine("Процесс удален");
                                        tem = 1;
                                        break;
                                    }
                                    else if (i == procc.Length - 1)  // Неверно введен номер ID
                                    {
                                        Console.WriteLine("Введен некорректный номер, введите снова");
                                    }
                                }

                            } while (tem == 0);
                        }
                        else Console.WriteLine("Процессов с этим именем не обнаружено");
                        temp = 1; // Программа завершится
                        break;



                    case "3": // Отображает список процессов
                        Console.WriteLine("Введите Имя процесса, который нужно завершить");
                        for (int i = 0; i < processes.Length; i++)
                        {
                            Console.Write("ID: " + processes[i].Id);
                            Console.WriteLine(" | Proc.Name: " + processes[i].ProcessName);
                            Console.WriteLine();
                        }
                        break;



                    default: // Повторяет снова, если введено не от 1 до 3 
                        Console.WriteLine("Введен некорректный выбор, введите снова");
                        break;

                }
            } while (temp==0);
            Console.WriteLine("Нажмите любую кнопку чтобы завершить программу"); // Для удобства


            Console.ReadLine();

        }
    }
}
