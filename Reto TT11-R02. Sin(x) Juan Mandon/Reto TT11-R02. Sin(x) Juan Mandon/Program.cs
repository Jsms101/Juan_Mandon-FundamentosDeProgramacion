using System;

namespace Reto_TT11_R02._Sin_x__Juan_Mandon
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, i; // contador
            double sinx, sinxii; 
            x = i = sinx = sinxii = 0; //dos sinx para hacer los calculos de 
                                       // "mayor nivel" (digeribles).


            static double Factorial(double datoUser)  //factorizador 
            {
                double result = 1;          //5! = 5x4x3x2x1
                                            // Factorial(8) 
                //i is counter
                for (double i = 1; i <= datoUser; i++)
                {
                    result *= i;
                }

                return result;
            }

            Console.WriteLine("Programa calculador de Sin(x)");
            Console.WriteLine("Digite el valor de x por favor");

            x = double.Parse(Console.ReadLine());

            for (i = 0; i < 100; i++) 
            {
                sinx = (Math.Pow(-1, i))/(Factorial((2*i)+1));

                sinxii += sinx * (Math.Pow(x, (2*i) + 1));

                Console.WriteLine(sinxii);


            }

            if (i >= 100)
            {
                
                Console.WriteLine("El valor de sin(" + x + ") es : " + sinxii + "");
            }

        }                  
    }
}
