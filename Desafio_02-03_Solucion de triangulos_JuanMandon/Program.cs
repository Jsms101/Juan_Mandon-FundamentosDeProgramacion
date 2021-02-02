using System;

namespace Desafio_02_03_Solucion_de_triangulos_JuanMandon
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double cRad, aRad, bRad, t, y, z, cGrad = 0; //bRad es 90° por defecto (en radianes)

            bRad = Math.PI / 2;

            //Introduccion en consola al programa
            Console.WriteLine("¡Este es un programa para calcular diversos valores desconocidos en un triangulo \n" +
                "mediante dos valores, c & z conocidos!");

            Console.WriteLine("\nLos valores que el programa entregará seran a, t & y.");



            //Toma de datos del usuario

            Console.WriteLine("\n\n Digite el valor conocido de c en grados por favor.");

            cGrad = double.Parse(Console.ReadLine());
            cRad = cGrad * (Math.PI / 180);                                  //pasar grados a radianes

            Console.WriteLine("Digite el valor conocido de z por favor.");

            z = double.Parse(Console.ReadLine());

            //Procesamiento de datos (formulas y demas)

            
            aRad = Math.PI - cRad - bRad;

            t =  z * Math.Sin(bRad) / Math.Sin(cRad);

            y =  z * Math.Sin(aRad) / Math.Sin(cRad) ;
           


            //de radianes a grados

            cRad = cRad * 180 / Math.PI;
            aRad = aRad * 180 / Math.PI;


            //Resultados

            Console.WriteLine("Para los valores c = " + cGrad + " z = " + z + " Los valores desconocidos serian: \n ");
            Console.WriteLine("a = " + aRad);
            Console.WriteLine("\nt = " + t);
            Console.WriteLine("\ny = " + y);

            Console.WriteLine("¡Gracias por usar la calculadora! Presione enter para terminar la aplicacion.");

            Console.ReadKey();
        }
    }
}
