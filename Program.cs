using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Seguinte Hora//
            DateTime Hora;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Hora = DateTime.Now;
            Console.Write($"Data e hora Recente:{Hora}");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(":Segundos");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}