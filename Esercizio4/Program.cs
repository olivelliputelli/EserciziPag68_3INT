using System;


namespace Esercizio4
{
    class Program
    {
        static void Main()
        {
            //variabili e inizializzazione
            double punteggio = 0.0d;
            string valutazione ="";

            //input
            Console.Write("Punteggio: ");
            punteggio = double.Parse(Console.ReadLine());

            //elaborazione
            if (punteggio >= 0 && punteggio <= 40)
            {
                valutazione = "E";
            }
            else if (punteggio >= 41 && punteggio <= 60)
            {
                valutazione = "D";
            }
            else if (punteggio >= 61 && punteggio <= 70)
            {
                valutazione = "C";
            }
            else if (punteggio >= 71 && punteggio <= 85)
            {
                valutazione = "B";
            }
            else if (punteggio >= 86 && punteggio <= 100)
            {
                valutazione = "A";
            }

            //output
            Console.WriteLine($"Con punteggio {punteggio} la valutazione è {valutazione}");
        }
    }
}
