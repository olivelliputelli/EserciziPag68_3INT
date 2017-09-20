using System;

namespace Esercizio1
{
    class Program
    {
        static void Main()
        {
            //variabili e inizailizzazione
            double raggio = 0.0d;
            double area = 0.0d;

            //input
            Console.Write("Raggio: ");
            raggio = double.Parse(Console.ReadLine());

            //elaborazione
            area = Math.PI * Math.Pow(raggio, 2);

            //output
            Console.WriteLine($"Il cerchio con raggio {raggio} ha l'area di {area}");
        }
    }
}
