using System;

namespace Desafio_02_01_Solucion_de_triangulos_JuanMandon
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double cRad, aRad, bRad, t, y, z = 0; //bRad es 90° por defecto (en radianes)

            bRad = Math.PI / 2;

            //Introduccion en consola al programa
            Console.WriteLine("¡Este es un programa para calcular diversos valores desconocidos en un triangulo \n" +
                "mediante dos valores, y & z conocidos!");

            Console.WriteLine("\nLos valores que el programa entregará seran t, a y c.");



            //Toma de datos del usuario

            Console.WriteLine("\n\n Digite el valor conocido de y por favor.");

            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor conocido de z por favor.");

            z = double.Parse(Console.ReadLine());

            //Procesamiento de datos (formulas y demas)

            //t = √(a^2 + c^2 - 2ac·cos(B))
            //∠A = arccos(bpw2 + c2 - a22bc)

            t = Math.Sqrt((Math.Pow(z, 2) + Math.Pow(y, 2)) - 2 * (z * y) * Math.Cos(bRad));

            cRad = Math.Acos((Math.Pow(t, 2) + Math.Pow(y, 2) - Math.Pow(z, 2)) / ((2 * t) * y)); //habia olvidado el - en la formula

            aRad = Math.Acos((Math.Pow(t, 2) + Math.Pow(z, 2) - Math.Pow(y, 2)) / ((2 * t) * z)); //y produjo una crisis expectacular en el codigo


            //de radianes a grados

            cRad = cRad * 180 / Math.PI;
            aRad = aRad * 180 / Math.PI;
           

            //Resultados

            Console.WriteLine("Para los valores y = " + y + " z = " + z + " Los valores desconocidos serian: \n ");
            Console.WriteLine("t = " + t);
            Console.WriteLine("\nc = " + cRad);
            Console.WriteLine("\na = " + aRad);

            Console.WriteLine("¡Gracias por usar la calculadora! Presione enter para terminar la aplicacion.");

            Console.ReadKey();









        }
    }
}
