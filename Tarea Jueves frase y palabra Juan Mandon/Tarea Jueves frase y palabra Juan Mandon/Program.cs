using System;
using System.Collections.Generic;

namespace Tarea_Jueves_frase_y_palabra_Juan_Mandon
{
    class Program           //video https://youtu.be/lkbFHivBBIw
    {
        static void Main(string[] args)
        {
            int contadorPalabra = 0;

            List<string> fraseLista = new List<string>();


            Console.WriteLine("Escriba una frase");
            string frase = Console.ReadLine();
            

            Console.WriteLine("Escriba una palabra");
            string palabra = Console.ReadLine();

            string fraseMayus = frase.ToUpper();
            string palabraMayus = palabra.ToUpper();

            //Console.WriteLine(frase.Length);


            string[] fraseString = new string[frase.Length];
            fraseString = frase.Split(); //
            fraseLista.AddRange(frase.Split());

           

            try
            {
                 //jUan is juan ------------ word:juan

                for (int i = 0; 0 < fraseLista.Count; i++)
                {
                    //Console.WriteLine(fraseString[i]);

                    if (fraseString[i] == palabra || fraseString[i].ToUpper() == palabra.ToUpper())
                    {
                        contadorPalabra += 1;

                        Console.WriteLine($"Encontrada la palabra {palabra} en la posicion " + (i+1));

                    }


                }
            }
            catch


            {
                Console.WriteLine("Index maximo superado, pero el programa sigue funcionando");
            }

            Console.WriteLine($"Cuantas veces se repite la palabra {palabra} en la frase: " + contadorPalabra);

        }
    }
}
