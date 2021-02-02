using System;

namespace Desafio_01__sistemas_numericos__Triangulos_Juan_mandon
{
    class Program
    {
        static void Main(string[] args)
        {


            //variables
            double hyperXY, topRightRad, cRad, aRad, bRad, noventaRad, bGrad, t, y, z, b, d, x = 0; //NoventaRad es 90° por defecto (en radianes)


            noventaRad = Math.PI / 2;

            //Introduccion en consola al programa.
            Console.WriteLine("Este es un programa para encontrar datos desconocidos de dos triangulos mediante diversos datos dados, en este caso" +
                "\n b, z & y. ");

            Console.WriteLine("\nEl programa entregara el valor de x");



            //Toma de datos del usuario

            Console.WriteLine("\n\n Digite el valor conocido de b en grados por favor.");

            bGrad = double.Parse(Console.ReadLine());
            bRad = bGrad * Math.PI / 180;                                 //grados a radianes

            Console.WriteLine("Digite el valor conocido de z por favor.");

            z = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor conocido de y por favor.");

            y = double.Parse(Console.ReadLine());

            //Procesamiento de datos para el triangulo pequeño

            //t = √(a^2 + c^2 - 2ac·cos(B))
            //∠A = arccos(bpw2 + c2 - a22bc)

            t = Math.Sqrt((Math.Pow(z, 2) + Math.Pow(y, 2)) - 2 * (z * y) * Math.Cos(noventaRad));

            cRad = Math.Acos((Math.Pow(t, 2) + Math.Pow(y, 2) - Math.Pow(z, 2)) / ((2 * t) * y)); //habia olvidado el - en la formula

            aRad = Math.Acos((Math.Pow(t, 2) + Math.Pow(z, 2) - Math.Pow(y, 2)) / ((2 * t) * z)); //y produjo una crisis expectacular en el codigo


            //procesamiento de datos para el triangulo grande

            topRightRad = aRad + bRad;    //grados de la parte superior derecha del triangulo grande
            d = Math.PI - noventaRad - topRightRad;

            hyperXY = z * Math.Sin(topRightRad) / Math.Sin(d); //HyperXY es la suma de x + y, o el lado inferior del triangulo.

            x = hyperXY - y;








            //de radianes a grados

            cRad = cRad * 180 / Math.PI;
            aRad = aRad * 180 / Math.PI;


            //Resultados

            Console.WriteLine("Para los valores b = " + bGrad + " z = " + z + " & y = " + y + " Los valores desconocidos serian: \n ");
            Console.WriteLine("x = " + x);
            //Console.WriteLine("\nc = " + cRad);
            //Console.WriteLine("\na = " + aRad);

            Console.WriteLine("¡Gracias por usar la calculadora! Presione enter para terminar la aplicacion.");

            Console.ReadKey();




        }
    }
}
