using System;

namespace _09_Ciclos_simulacro_p2__1__Juan_Mandon
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            int puntaje, vidas, unosObtenido, seisObtenido, numDadosSpecial;
            int dado6Caras, dado12Caras;
            bool puedeContinuar, usoDadoSeis;
            string deseaContinuar, tipoDeDados;
            

            puedeContinuar = true;
            puntaje  = unosObtenido = seisObtenido = 0;
            vidas = 3; //vida max es 3.
            numDadosSpecial = 2; //inicias con dos


            //randomizer
            Random random = new Random();
            



            Console.WriteLine("Juego de dados");

            while (puedeContinuar && vidas > 0)
            {
                StartAsking1:

                if (vidas > 3) vidas = 3;

                Console.WriteLine("\nVidas restantes: " + vidas);
                Console.WriteLine("Puntaje actual: " + puntaje);
                Console.WriteLine("Numero de dados especiales restantes: " + numDadosSpecial);


                Console.WriteLine("\n¿Desea continuar? (s/n)");
                deseaContinuar = Console.ReadLine();

                if (deseaContinuar == "s")
                {
                    StartAsking2:
                    dado6Caras = 0;
                    dado12Caras = 0;
                    usoDadoSeis = false; //para soportar la funcionalidad de dado 12 caras

                    Console.WriteLine("\n(n) deseas usar dados normales ");
                    Console.WriteLine("ó\n(s) ¿Deseas usar dados especiales? Tienes " + numDadosSpecial);
                    tipoDeDados = Console.ReadLine();

                    //dado 6 caras
                    if (tipoDeDados == "n")
                    {
                        dado6Caras = random.Next(1, 7);
                        puntaje += dado6Caras;
                        usoDadoSeis = true;
                        Console.WriteLine("\nObtuviste con tu dado de seis caras el numero " + dado6Caras);

                    }
                    else if (tipoDeDados != "s")
                    {
                        Console.WriteLine("\nEntrada no reconocida, intente de nuevo.");
                        goto StartAsking2;
                    } //end

                    if(usoDadoSeis == false) //para que solo se pueda usar el dado12 si no decidio usar el dado seis
                    {
                        //dado 12 caras
                        if (tipoDeDados == "s" && numDadosSpecial > 0)
                        {
                            dado12Caras = random.Next(1, 13);
                            puntaje += dado12Caras;
                            Console.WriteLine("\nObtuviste con tu dado de doce caras el numero " + dado12Caras);
                            numDadosSpecial -= 1;

                        }
                        else if (numDadosSpecial < 1)
                        {
                            Console.WriteLine("\nNo tienes mas dados especiales, intente de nuevo.");
                            goto StartAsking2;
                        }
                        else if(tipoDeDados != "n" && numDadosSpecial > 0)
                        {
                            Console.WriteLine("\nEntrada no reconocida, intente de nuevo.");
                            goto StartAsking2; 
                        } //end
                    }

                    



                    //fruther data processing: 1s y 6s

                    //1s dobles que restan una vida, no consecutivos
                    if (dado6Caras == 1 || dado12Caras == 1) 
                    {
                        Console.WriteLine("Obtuviste un 1, cuidado!");
                        unosObtenido += 1;
                    }

                    if (unosObtenido == 2)
                    {
                        Console.WriteLine("Obtuviste dos 1s! Pierdes una vida!");
                        vidas -= 1;
                        puntaje -= 10;

                        unosObtenido = 0;
                    }

                    //sumador de vidas 6s * 2 consecuitvos
                    if(dado6Caras == 6 || dado12Caras == 6)
                    {
                        Console.WriteLine("Obtuviste un 6, suertudo!");
                        seisObtenido += 1;
                    }
                    else
                    {
                        seisObtenido = 0;
                    }

                    if(seisObtenido == 2)
                    {
                        Console.WriteLine("Obtuviste dos 6s seguidos! Epico! Ganas una vida!");
                        vidas += 1;
                        seisObtenido = 0;
                    }


                }  //end of deseacontinuar loop
                else if(deseaContinuar == "n")
                {
                    Console.WriteLine("Haz decidido no continuar");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no reconocida, intente de nuevo.");
                    goto StartAsking1;
                }


                // ending
                if (puntaje > 100)
                {
                    Console.WriteLine("¡Eres epico! Obtuviste mas de 100 puntos! Ganaste el juego.");
                    puedeContinuar = false;
                    break;
                }

                if (vidas < 1)
                {
                    Console.WriteLine("Te quedaste sin vidas, ¡Has perdido!");
                    puedeContinuar = false;
                    break;
                }

                


            }

            Console.WriteLine("El juego ha finalizado.");
            Console.WriteLine("\nEstadisticas:");
            Console.WriteLine("Vidas restantes: " + vidas);
            Console.WriteLine("Puntaje final: " + puntaje);
            Console.WriteLine("Numero de dados especiales restantes: " + numDadosSpecial);
            Console.WriteLine("\n¡Gracias por jugar!");   // :)

        }
    }
}
