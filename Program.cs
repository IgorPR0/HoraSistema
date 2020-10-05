using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Hora;

            Hora = DateTime.Now;
            Console.Write("Data e hora Recente: ");
            Console.WriteLine($"{Hora}");
            Console.WriteLine();

            Console.WriteLine(" Okay !");
            Console.ReadKey();
        }
    }
}