using System;

namespace Desafio_02__sistemas_numericos__Triangulos_Juan_mandon
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            double hyperXY, topRightRad, cRad, eRad, aRad, bRad, dRad, noventaRad, bGrad, dGrad, baRad, t, y, z, b, d, e, x = 0; //NoventaRad es 90° por defecto (en radianes)


            noventaRad = Math.PI / 2;

            //Introduccion en consola al programa.
            Console.WriteLine("Este es un programa para encontrar datos desconocidos de dos triangulos mediante diversos datos dados, en este caso" +
                "\n d, b & y. ");

            Console.WriteLine("\nEl programa entregara el valor de z");



            //Toma de datos del usuario

            Console.WriteLine("\n\n Digite el valor conocido de d en grados por favor.");

            dGrad = double.Parse(Console.ReadLine());
            dRad = dGrad * Math.PI / 180;                                 //grados a radianes

            Console.WriteLine("\n\n Digite el valor conocido de b en grados por favor.");

            bGrad = double.Parse(Console.ReadLine());
            bRad = bGrad * Math.PI / 180;

            Console.WriteLine("Digite el valor conocido de y por favor.");

            y = double.Parse(Console.ReadLine());

            
            //procesamiento de datos para el triangulo grande

            eRad = Math.PI - (dRad + bRad);  //con esto calculamos el lado de e, que es 180 - la suma de los dos angulos restantes

            baRad = Math.PI - (dRad + noventaRad);//grados de la parte superior derecha del triangulo grande
            aRad = baRad - bRad;

            //con los datos arad, noventarad & y podemos calcular z en el triangulo pequeño

            //Procesamiento de datos para el triangulo pequeño

            cRad = Math.PI - (noventaRad + aRad);

            z = (y * Math.Sin(cRad))/Math.Sin(aRad);







            //de radianes a grados

            //cRad = cRad * 180 / Math.PI;
            //aRad = aRad * 180 / Math.PI;


            //Resultados

            Console.WriteLine("Para los valores d = " + dGrad + " b = " + bGrad + " & y = " + y + " Los valores desconocidos serian: \n ");
            Console.WriteLine("z = " + z);
            //Console.WriteLine("\nc = " + cRad);
            //Console.WriteLine("\na = " + aRad);

            Console.WriteLine("¡Gracias por usar la calculadora! Presione enter para terminar la aplicacion.");

            Console.ReadKey();


        }
    }
}
