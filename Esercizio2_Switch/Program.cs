using System;

namespace Esercizio2_Switch
{
    /// <summary>
    /// Esercizio svolto con l'istruzione switch
    /// </summary>
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("L - Asfalto");
            Console.WriteLine("B - Asfalto ");
            Console.WriteLine("G - Asfalto ");
            Console.Write("(R, L, B, G): ");
            condizioniAsfalto = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Velocità: ");
            velocita = double.Parse(Console.ReadLine());

            // Elaborazione
            switch (condizioniAsfalto)
            {
                case 'R':
                    coefficienteF = 0.6;
                    break;
                case 'L':
                    coefficienteF = 0.5;
                    break;
                case 'B':
                    coefficienteF = 0.4;
                    break;
                case 'G':
                    coefficienteF = 0.1;
                    break;
                default:
                    coefficienteF = 0;
                    break;
            }

            spazioFrenata = Math.Pow(velocita, 2) / (250 * coefficienteF);

            // Output
            Console.WriteLine($"Lo spazio di frenata è {spazioFrenata} metri!");
        }
    }
}
