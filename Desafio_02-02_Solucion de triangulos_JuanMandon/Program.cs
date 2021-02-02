using System;

namespace Desafio_02_02_Solucion_de_triangulos_JuanMandon
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double cRad, aRad, bRad, t, y, z, takenRad = 0; 

            bRad = Math.PI / 2;                  //bRad es 90° por defecto (en radianes)

            //Introduccion en consola al programa
            Console.WriteLine("¡Este es un programa para calcular diversos valores desconocidos en un triangulo \n" +
                "mediante dos valores, t & a conocidos!");

            Console.WriteLine("\nLos valores que el programa entregará seran c, y & z.");



            //Toma de datos del usuario

            Console.WriteLine("\n\n Digite el valor conocido de t por favor.");

            t = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor conocido de a en grados por favor.");

            takenRad = double.Parse(Console.ReadLine());   //variable takenrad para poder mostrar "grados" al final en la consola y tomar los datos

            aRad = takenRad;                              

            aRad = aRad * Math.PI / 180; //Grados a Radianes

            //Procesamiento de datos (formulas y demas)

            //cRad = π rad - bRad - aRad

            cRad = Math.PI - bRad - aRad;

            z = ( t * Math.Sin(cRad) ) / Math.Sin(bRad);

            y = ( t * Math.Sin(aRad) ) / Math.Sin(bRad); 



            //de radianes a grados

            cRad = cRad * 180 / Math.PI;
            aRad = aRad * 180 / Math.PI;


            //Resultados

            Console.WriteLine("Para los valores t = " + t + " a = " + aRad + " Los valores desconocidos serian: \n ");
            Console.WriteLine("c = " + cRad);
            Console.WriteLine("\ny = " + y);
            Console.WriteLine("\nz = " + z);

            Console.WriteLine("¡Gracias por usar la calculadora! Presione enter para terminar la aplicacion.");

            Console.ReadKey();
        }
    }
}
