using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Морской бой");
        string[,] seaBattle = new string[10, 10] 
        {
        {"X", "0", "X", "0", "0", "0", "0", "X", "X", "X", },
        {"0", "0", "X", "0", "0", "0", "0", "0", "0", "0", },
        {"0", "0", "X", "0", "0", "0", "0", "X", "0", "0", },
        {"0", "0", "X", "0", "0", "0", "0", "X", "0", "X", },
        {"0", "0", "0", "0", "0", "0", "0", "0", "0", "X", },
        {"0", "0", "0", "0", "0", "0", "0", "0", "0", "X", },
        {"0", "0", "0", "X", "X", "0", "0", "0", "0", "0", },
        {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", },
        {"0", "0", "0", "0", "0", "0", "0", "X", "0", "0", },
        {"X", "0", "0", "X", "0", "0", "0", "X", "0", "X", }
        };

        for (int i = 0; i < seaBattle.GetLength(0); i++) 
        {
            for (int j = 0; j < seaBattle.GetLength(0); j++) 
            {
                if (j != 9) Console.Write("{0} ", seaBattle[i, j]);
                else Console.WriteLine("{0} ", seaBattle[i, j]);
            }
        }
        Console.ReadLine();
    }
}