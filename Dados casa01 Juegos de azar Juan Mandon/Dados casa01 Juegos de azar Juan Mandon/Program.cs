using System;

namespace Dados_casa01_Juegos_de_azar_Juan_Mandon
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
            double ii= 0; //para contar para la divison del porcentaje.

            string quiereSeguir = "s"; //para revisar si el usuario desea seguir.

            /*Console.WriteLine("Primero, ¿Bajo que modo de juego deseas jugar?"
                +"\n(1)Standard + contador finalizacion & demas\n(2)+Todas las Condiciones adicionales"); */

            //int gamemode = int.Parse(Console.ReadLine());


            while ((puedetirar == true) & quiereSeguir == "s")
            {

                Console.WriteLine("Deseas tirar los dos dados? (s/n) (El primer turno es obligatorio)");
                 quiereSeguir= Console.ReadLine();

                if (quiereSeguir == "n")
                {
                    Console.WriteLine("Te retiras de la partida...");
                    break;
                }

                dado1 = randm.Next(1, 7);
                dado2 = randm.Next(1, 7);
                puntaje = puntaje +dado1 +dado2;
                puntajeSoloDados = dado1 + dado2;
               
                Console.WriteLine("Has sacado para el dado primero: " + dado1 + " y para el\n" +
                    "dado segundo: "+ dado2 +" en total tienes " + puntaje + " puntos!");


                
                if ((dado1 == 1 & dado2 == 1) ) //gm2
                {
                    Console.WriteLine("Oh no! has sacado " + dado1 + " y " + dado2 + " signifca\n" +
                        "¡Que pierdes!");
                    puedetirar = false;

                }

                if (puntaje >= 100)
                {
                    Console.WriteLine("¡Woah!¡Eres epico! ¡Se nota que le metiste \n" +
                        "puntos extra a la stat de suerte! ¡Jeje!");
                    puedetirar = false;
                }

                if(puntajeSoloDados > 6)
                {
                    ii++;
                }

                

                if((dado1 == dado2) & dado1 != 1 & dado2 !=1)
                {
                    threeParWin++;
                }

                if (threeParWin ==3)
                {
                    Console.WriteLine("¡Oh dios mio! ¿Eres pay to win o \ngastaste todos tus puntos a la estadistica de suerte???" +
                        "Has sacado tres dobles consecutivos y ¡Efectivamente ganas!");
                }

                i++;
            }

            //processing

            porcentaje = (ii/i)*100;

            Console.WriteLine("El juego ha terminado...\n-Estadisticas- ");
            Console.WriteLine("El porcentaje de turnos donde la suma fue superior a 6 fue: "+porcentaje + "%");
            Console.ReadLine();

           




        }
    }
}
