using System;

namespace Spiegazione
{
    class Program
    {
        static void Main()
        {
            char tipo;
          



            //Console.Write("Tipo: ");
            //tipo = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Colore: ");
            colore = (Colori)Enum.Parse(typeof(Colori), Console.ReadLine().ToUpper());

            switch (colore)
            {
                case Colori.ROSSO:
                    Console.WriteLine("Hai scelto il colore più caldo!");
                    break;
                case Colori.VERDE:
                    Console.WriteLine("Hai scelto il colore più naturale!");
                    break;
                case Colori.BLU:
                    Console.WriteLine("Hai scelto il colore del mare!");
                    break;
                case Colori.GIALLO:
                    Console.WriteLine("Hai scelto il colore del semaforo!");
                    break;
                case Colori.BIANCO:
                    Console.WriteLine("Hai scelto il colore più chiaro!");
                    break;
                case Colori.NERO:
                    Console.WriteLine("Hai scelto il colore più scuro!");
                    break;
            }



            //switch (tipo)
            //{
            //    case 'A':
            //    case 'B':
            //        switch (colore)
            //        {
            //            case "ROSSO":
            //                Console.WriteLine("A oppure B di colore Rosso");
            //                break;
            //            case "VERDE":
            //                Console.WriteLine("A oppure B di colore Verde");
            //                break;
            //            default:
            //                Console.WriteLine("A oppure B di colore non valido");
            //                break;
            //        }
            //        Console.WriteLine("FINE BLOCCO!");
            //        break;
            //    case 'C':
            //        Console.WriteLine("C");
            //        break;
            //    default:
            //        Console.WriteLine("Non hai inserito un tipo valido!");
            //        break;
            //}
            Console.WriteLine("FINE!!!");

            //Console.WriteLine($"gli INT vanno da {int.MinValue} fino a {int.MaxValue}");


            //int numero = 2000000000;

            //numero = numero + 200000000;



            //Console.WriteLine(numero);


            //int numero = 0;
            //do
            //{
            //    Console.Write("Numero: ");
            //    numero = int.Parse(Console.ReadLine());
            //} while (numero != 0);





            //string nomeSocieta = "Pippo € e Pluto";

            //System.Console.WriteLine(nomeSocieta);


            // Namespace.Classe.Metodo();



        }
    }


    enum Colori
    {
        ROSSO,
        VERDE,
        BLU,
        GIALLO,
        BIANCO,
        NERO            
    }

}
