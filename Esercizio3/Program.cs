using System;


namespace Esercizio3
{
    class Program
    {
        static void Main()
        {
            //variabili e inizializzazione
            double temperaturaReale = 0.0d;
            double velocitaVento = 0.0d;
            double temperaturaPercepita = 0.0d;

            //input
            Console.Write("Temperatura reale: ");
            temperaturaReale = double.Parse(Console.ReadLine());
            Console.Write("Velocità del vento: ");
            velocitaVento = double.Parse(Console.ReadLine());

            //elaborazione
            if (velocitaVento > 5)
            {
                temperaturaPercepita = 33 + (0.45 + 0.29 * Math.Sqrt(velocitaVento) - 0.02 * velocitaVento) * (temperaturaReale - 33);
            }
            else
            {
                temperaturaPercepita = temperaturaReale;
            }

            //output
            Console.WriteLine($"La temperatura percepita con una temperatura reale di {temperaturaReale} °C e con velocità del vento di {velocitaVento} mph è di {temperaturaReale}°C");
        }
    }
}
