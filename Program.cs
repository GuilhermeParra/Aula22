using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            float valorUSS;
            
            Console.WriteLine (Conversor.DolarParaReal( valorUSS = float.Parse(Console.ReadLine())));

            Console.ResetColor();
        }
    }
}
