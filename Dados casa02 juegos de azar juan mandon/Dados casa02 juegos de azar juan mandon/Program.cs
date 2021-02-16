using System;

namespace Dados_casa02_juegos_de_azar_juan_mandon
{
    class Program
    {
            static void Main(string[] args)
            {
            Random randm = new Random();

            bool puedetirar = true;
            int dado1, dado2, puntaje, contPuntajeSolo; //= randm.Next (0,6);
            int puntajeSoloDados, turnos; //para realizar contador de finalizacion & contador
            double i = 0; //para contar los turnos
            int threeParWin; //para ver si se gana x sacar 3 dados pares seguidos.
            puntaje = contPuntajeSolo = 0;
            double porcentaje = 0;
            threeParWin = 0;
            double ii = 0; //para contar para la divison del porcentaje.
            int iii = 0; // para dar los 3 primeros turnos libres 
            int iiii = 0; //para contar si obtiene 12 y despues 10

            string quiereSeguir = "s"; //para revisar si el usuario desea seguir.

            int dadoFuture1, dadoFuture2;
            dadoFuture1 = dadoFuture2 = 0;
            dado1 = 2;

            /*Console.WriteLine("Primero, ¿Bajo que modo de juego deseas jugar?"
                +"\n(1)Standard + contador finalizacion & demas\n(2)+Todas las Condiciones adicionales"); */

            //int gamemode = int.Parse(Console.ReadLine());


            while ((puedetirar == true) & quiereSeguir == "s" )
            {
                dado1 = 0;
                Console.WriteLine("Deseas tirar los dos dados? (s/n) (El primer turno es obligatorio)");
                quiereSeguir = Console.ReadLine();

                if (quiereSeguir == "n")
                {
                    Console.WriteLine("Te retiras de la partida...");
                    break;
                }

                dado1 = randm.Next(1, 13);
               
                puntaje = puntaje + dado1 ;
                puntajeSoloDados = dado1 ;

                Console.WriteLine("Has sacado para el dado primero: " + dado1 + " y para el\n total tienes " + puntaje + " puntos!");

                iii++;

                if (((dado1%2)==0) ) //gm2
                {
                    
                   

                }
                else
                {
                    if (iii>3)
                    {
                        Console.WriteLine("Oh no! has sacado impar: " + dado1 + " signifca ¡Que pierdes!");
                        puedetirar = false;
                        
                        break;
                    }
                    
                }

                if (puntaje >= 100)
                {
                    Console.WriteLine("¡Woah!¡Eres epico! ¡Se nota que le metiste \n" +
                        "puntos extra a la stat de suerte! ¡Jeje!");
                    puedetirar = false;
                }

                if (puntajeSoloDados > 6)
                {
                    ii++;
                }




                if (dado1 == 12)
                {
                    dadoFuture1 = 12;
                }
                else dadoFuture1 = 0;


                if (dado1 == 10 && dadoFuture1 == 12)
                {
                    Console.WriteLine("¡Woah!Ganaste por sacar 12 y despues 10!");
                    puedetirar = false;
                    break;
                }
                else dadoFuture1 = 0;

                i++;
            }

            //processing

            porcentaje = (ii / i) * 100;

            Console.WriteLine("El juego ha terminado...\n-Estadisticas- ");
            Console.WriteLine("El porcentaje de turnos donde la suma fue superior a 6 fue: " + porcentaje + "%");
            Console.ReadLine();

        }
        
    }
    
}
