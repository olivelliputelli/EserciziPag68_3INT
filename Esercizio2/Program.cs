using System;

/// <summary>
/// Esercizio svolto con l'istruzione if else if
/// </summary>
namespace Esercizio2
{
    class Program
    {
        static void Main()
        {
            double coefficienteF = 0.0d;
            double velocita = 0.0d;
            char condizioniAsfalto;
            double spazioFrenata = 0.0d;

            // Input
            Console.WriteLine("*** E S E R C I Z I O  N. 2  PAG.68 ***");
            Console.WriteLine("");
            Console.WriteLine("Condizioni stradali");
            Console.WriteLine("R - Asfalto ruvido");
            Console.WriteLine("L - Asfalto liscio");
            Console.WriteLine("B - Asfalto bagnato");
            Console.WriteLine("G - Asfalto ghiacciato");
            Console.Write("(R, L, B, G): ");
            condizioniAsfalto = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Velocità: ");
            velocita = double.Parse(Console.ReadLine());

            // Elaborazione
            if (condizioniAsfalto == 'R')
            {
                coefficienteF = 0.6;
            }
            else if (condizioniAsfalto == 'L')
            {
                coefficienteF = 0.5;
            }
            else if (condizioniAsfalto == 'B')
            {
                coefficienteF = 0.4;
            }
            else if (condizioniAsfalto == 'G')
            {
                coefficienteF = 0.1;
            }
            else
            {
                coefficienteF = 0;
            }

            spazioFrenata = Math.Pow(velocita, 2) / (250 * coefficienteF);

            // Output
            Console.WriteLine($"Lo spazio di frenata è {spazioFrenata} metri!");
        }
    }
}
