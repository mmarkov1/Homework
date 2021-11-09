using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите слово");
        char[] charmas = Console.ReadLine().ToCharArray();
        for (int i = 0; i < charmas.Length; i++) 
        {
            Console.Write(charmas[charmas.Length - i - 1]);
        }
    }
}