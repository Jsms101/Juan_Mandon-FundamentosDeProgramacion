using System;

namespace T1___Reto_1_JUAN_MANDON
{
        class Program
    {


        static void Main(string[] args)
        {
            //Developed by Juan Sebastian

            double x1, y1, x2, y2 = 1; //valor default

            double Pendiente, /*Intercepto, Intercepto2,*/ Distancia, Interseccion;

            bool restart = true;
            string YesnO;

            Console.WriteLine("Calculadora de pendiente, intercepto y distancia " +
            "de dos coordenadas\n'(x1 , y1 ) y (x2 , y2 )'. Presione 'Enter' para continuar...\n");

            Console.ReadKey();
            while (restart == true) //loop calculadora (ease of use)
            {
                Console.WriteLine("Para implementar la calculadora digite el valor x1 de la primera coordenada. \n");
                x1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el valor y1 de la primera coordenada. \n");
                y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ahora digite el valor x2 de la segunda coordenada. \n");
                x2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Por ultimo digite el valor y2 de la segunda coordenada. \n");
                y2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Procesando, espere un momento...\n");

                double x = Math.Sqrt(Math.Pow(x2 - x1, 2));
                double y = Math.Sqrt(Math.Pow(y2 - y1, 2));


                Pendiente = (y2 - y1) / (x2 - x1);
                Interseccion = y1 - (Pendiente * x1);

                //Intercepto = (y/Interseccion)/x;

                // Intercepto = Pendiente * x + Interseccion; 
                // Intercepto2 = (y / Pendiente) - Interseccion; 

                Distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                Console.WriteLine("Pendiente = " + Pendiente);
                Console.WriteLine("Intercepto en Y = " + Interseccion);
                Console.WriteLine("Distancia = " + Distancia);

                Console.WriteLine("¡Gracias por usar la calculadora! ¿Desea seguir usando\n" +
                "la calculadora? Y/N .");
                YesnO = Console.ReadLine();

                if (YesnO == "Y")
                {
                    restart = true;
                }
                else restart = false;
            }

            if (restart == false)
            {
                Console.WriteLine("¡Gracias por usar la calculadora! Presione enter para terminar\n" +
                    "el programa.");

                Console.ReadKey();
            }
           

           











        }


    }
    
}
   