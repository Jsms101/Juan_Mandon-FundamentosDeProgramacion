using System;

namespace _09_Ciclos_simulacro_p2__2__Juan_Mandon
{
    class Program
    {
        static void Main(string[] args)
        {

            //vars
            int puntaje, vidas, unosObtenido, seisObtenido, numDadosSpecial, turnos;
            int dado6Caras, dadoDoble, turnosContadorFix, contadorDoble;
            bool puedeContinuar, turnoDoble;
            string deseaContinuar, tipoDeDados;
            turnoDoble = false;
            


            puedeContinuar = true;
            puntaje = unosObtenido = seisObtenido = turnos = dadoDoble = 0;
            vidas = 3; //vida max es 3.
            numDadosSpecial = 2; //inicias con dos
            turnosContadorFix = 1;
            contadorDoble = 0;


            //randomizer
            Random random = new Random();




            Console.WriteLine("Juego de dados");

            while (puedeContinuar && vidas > 0)
            {
            StartAsking1:

                if (vidas < 1)
                {
                    Console.WriteLine("Te quedaste sin vidas, ¡Has perdido!");
                    puedeContinuar = false;
                    break;
                }

                //if (vidas > 3) vidas = 3; //no estaba estipulado en la segunda parte
                //que habia limite de vidas
                turnosContadorFix += turnos;
                Console.WriteLine("\nVidas restantes: " + vidas);
                Console.WriteLine("Puntaje actual: " + puntaje);
                Console.WriteLine("Turno actual: " + turnos);
                


                Console.WriteLine("\n¿Desea continuar? (s/n)");
                deseaContinuar = Console.ReadLine();

                if (deseaContinuar == "s")
                {

                    turnoDoble = false;

                    StartAsking2:
                    dado6Caras = 0;
                   
                    

                    Console.WriteLine("\n(n) deseas usar dados normales ");
                   
                    tipoDeDados = Console.ReadLine();

                    //dado 6 caras
                    if (tipoDeDados == "n")
                    {
                        turnos = turnos + 1;
                        dado6Caras = random.Next(1, 7);
                        puntaje += dado6Caras;
                        
                        Console.WriteLine("\nObtuviste con tu dado de seis caras el numero " + dado6Caras);

                    }
                    else
                    {
                        Console.WriteLine("\nEntrada no reconocida, intente de nuevo.");
                        goto StartAsking2;
                    } //end

                    //fruther data processing

                    //2 turnos -1 vida
                    if (turnos % 2 == 0 && turnoDoble == false)
                    {
                        Console.WriteLine("Han pasado dos turnos, pierdes una vida!");
                        vidas -= 1;
                    }

                    // usar dos dados cada 3 turnos

                    while(turnos%3 == 0)
                    {
                        Console.WriteLine("\nVidas restantes: " + vidas);
                        Console.WriteLine("Puntaje actual: " + puntaje);
                        Console.WriteLine("Turno actual: " + turnos);

                        int dadoDobleDos = 0;
                        Console.WriteLine("\nTurno doble! Pues estas en un tercer turno! ");

                        turnoDoble = true;
                            
                        //turnos -= 1;
                            
                        dado6Caras = random.Next(1, 7);
                        puntaje += dado6Caras;
                        Console.WriteLine("Obtienes " + dado6Caras + " en tu turno doble!");
                        

                        dadoDobleDos = random.Next(1, 7);
                        Console.WriteLine("Obtienes " + dadoDobleDos + " en tu turno doble!");

                        dadoDoble = dado6Caras;

                            if (dadoDobleDos == dado6Caras) //para ver si vida extra
                            {
                                Console.WriteLine("Obtienes dos dados iguales en tu turno doble!");
                                Console.WriteLine("Obtienes una vida adicional!");
                                vidas += 1;
                                dadoDoble = dado6Caras = 0;



                            }
                            else dadoDoble = dado6Caras = 0;


                        Console.WriteLine("Termino tu turno doble");
                        goto StartAsking1;
                    }

                    

                    


                }  //end of deseacontinuar loop
                else if (deseaContinuar == "n")
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
            end:

            Console.WriteLine("El juego ha finalizado.");
            Console.WriteLine("\nEstadisticas:");
            Console.WriteLine("Vidas restantes: " + vidas);
            Console.WriteLine("Puntaje final: " + puntaje);
            Console.WriteLine("\n¡Gracias por jugar!");   // :) :))))))))

        }
    }
}
