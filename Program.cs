using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            float valorUSS;
            float valorRS;
            
            Console.WriteLine (Conversor.DolarParaReal(valorUSS = float.Parse(Console.ReadLine())));
            Console.WriteLine (Conversor.RealParaDolar(valorRS = float.Parse(Console.ReadLine())));

            Console.ResetColor();
        }
    }
}
