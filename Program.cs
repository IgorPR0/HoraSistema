using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Hora;
            Hora = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Data e hora Recente:{Hora}");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(":Segundos");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}