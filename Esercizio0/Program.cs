using System;

namespace Esercizio0
{
    /// <summary>
    /// Dati base ed altezza di un triangolo isoscele calcolare area e perimetro.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** TRIANGOLO ISOSCELE ***");

            //variabili e inizializzazione
            double b = 0.0d, h = 0.0d;
            double area = 0.0d, perimetro = 0.0d;
            double cateto = 0.0d;

            //input
            Console.Write("Base: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Altezza: ");
            h = double.Parse(Console.ReadLine());

            // Elaborazione
            cateto = Math.Sqrt(Math.Pow(b / 2, 2) + Math.Pow(h, 2));
            area = b * h / 2;
            perimetro = b + cateto * 2;

            // Output
            Console.WriteLine($"Il triangolo con base {b} e altezza {h} ha l'area di {area} e il perimetro di {perimetro}");
        }
    }
}
