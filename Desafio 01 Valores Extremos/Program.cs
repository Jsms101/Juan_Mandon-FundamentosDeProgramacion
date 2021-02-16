using System;

namespace Desafio_01_Valores_Extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string edadMayorNombr, edadMenorNombr, nombre;
            double edadMayor, edadMenor;
            i = 1;
            double total = 0;
            edadMayor = edadMenor = 0;

            Console.WriteLine("Ingrese el numero de personas de las cuales se procesara la edad");
            int numPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la edad de la persona no.1");
            double edad = double.Parse(Console.ReadLine());
            total = total + edad;
            Console.WriteLine("Digite el nombre de la persona no.1");
            nombre = Console.ReadLine();



            edadMayorNombr = edadMenorNombr = nombre;
            

            edadMenor = edadMayor = edad;

            while (i < numPersonas)
            {
                

                if (edadMayor < edad) //si edad es mayor...
                {
                    edadMayor = edad;
                    edadMayorNombr = nombre;

                }
                if (edadMenor > edad) //si edad es menor...
                {
                    edadMenor = edad;
                    edadMenorNombr = nombre;
                }

                i++;            //Contadores

                Console.WriteLine("Digite la edad de la persona no." + i);
                edad = double.Parse(Console.ReadLine());
                total = total + edad;

                Console.WriteLine("Digite el nombre de la persona no." + i);
                nombre = Console.ReadLine();

            }

            //procesador menor ó mayor;


            double promedio = total / numPersonas;
            Console.WriteLine("El promedio de las edades es :" + promedio);
            Console.WriteLine("El de mayor edad es " + edadMayorNombr + " con " + edadMayor+ " años.");
            Console.WriteLine("El de menor edad es " + edadMenorNombr + " con " + edadMenor + " años.");


        }
    }
}
