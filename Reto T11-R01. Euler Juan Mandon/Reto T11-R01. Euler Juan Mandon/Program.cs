using System;

namespace Reto_T11_R01._Euler_Juan_Mandon
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, i;   //i is counter
            double ex = 1;
            x = i = 0;


            static double Factorial(double datoUser)  //factorizador
            {
                double result = 1;          //5! = 5x4x3x2x1 

                //i is counter
                for (double i = 1; i <= datoUser; i++)
                {
                    result *= i;
                }

                return result;
             
            }


            Console.WriteLine("Programa calculador de euler (e^x)");
            Console.WriteLine("Digite el valor de x");

            x = int.Parse(Console.ReadLine());

            for (i = 1; i < 100; i++)
            {
                ex += (Math.Pow(x,i)/Factorial(i));

                Console.WriteLine(ex);
            }

            if (i>= 100)
            {
                Console.WriteLine("El valor de e^" + x + " es : " + ex + "");
            }





        }
    }
}
