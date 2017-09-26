using System;

namespace Esercizio5
{
    class Program
    {
        static void Main()
        {
            // VAR
            char durata, priorita, zona;
            double prezzo = 0.0d;

            // INPUT
            Console.WriteLine("*** ESERCIZIO 5 ***");
            Console.WriteLine("DATI ABBONAMENTO");

            Console.Write("Durata (S = Settimanale, M = Mensile, A = Annuale): ");
            durata = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Tipo (1 = Zona periferica, 2 = Zona centrale, 3 = Entrambe): ");
            zona = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Priorità (B = bassa, A = alta): ");
            priorita = char.Parse(Console.ReadLine().ToUpper());

            // ELABORAZIONE
            switch (zona)
            {
                case '1':
                    switch (durata)
                    {
                        case 'S':
                            prezzo = 10;
                            break;
                        case 'M':
                            prezzo = 30;
                            break;
                        case 'A':
                            prezzo = 250;
                            break;
                    }
                    break;
                case '2':
                    switch (durata)
                    {
                        case 'S':
                            prezzo = 5;
                            break;
                        case 'M':
                            prezzo = 20;
                            break;
                        case 'A':
                            prezzo = 150;
                            break;
                    }
                    break;
                case '3':
                    switch (durata)
                    {
                        case 'S':
                            prezzo = 15;
                            break;
                        case 'M':
                            prezzo = 40;
                            break;
                        case 'A':
                            prezzo = 300;
                            break;
                    }
                    break;
            }
            if (priorita == 'B')
                prezzo = 0.8 * prezzo;

            //OUTPUT
            Console.WriteLine($"Il prezzo dell'abbonamento è {prezzo} euro.");
        }
    }
}
