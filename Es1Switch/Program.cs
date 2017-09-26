using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1Switch
{
    /// <summary>
    /// Dato un voto numerico intero restituire il giudizio in lettere secondo 
    /// il seguente schema:
    /// 1, 2, 3: Gravemente Insufficente
    /// 4: Insufficente
    /// 5: Quasi sufficente
    /// 6: Sufficente
    /// 7, 8: Buono
    /// 9: distinto
    /// 10: ottimo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Numero: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{n} è pari");
                }
                else
                {
                    Console.WriteLine($"{n} è dispari");
                }
            } while (n != 0);

            Console.WriteLine("FINE!!");
        }
    }
}
