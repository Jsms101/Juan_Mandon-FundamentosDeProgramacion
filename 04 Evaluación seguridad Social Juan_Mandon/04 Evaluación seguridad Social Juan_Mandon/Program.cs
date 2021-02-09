using System;

namespace _04_Evaluación_seguridad_Social_Juan_Mandon
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTA!

            //Cuenta como dos entregas, pues el trabajo de por si esta realizado con switch statements originalmente

            while (1 < 2) //para facilitar el testing
            {


                double salarioMensual, salarioMensualReal, salarioAnualReal, salario4Deduccion, SMMLV;
                double eps, arl, pension, prima;
                double deduccionesTotal;
                int tipoContrato, claseRiesgo;
                eps = arl = pension = prima = 0; //para evitar problemas por variables sin valor (los datos seran derivados de la entrada del usuario)



                SMMLV = 908526; //segun 2021, enero 1

                //toma de datos

                Console.WriteLine("Digite su salario mensual");
                salarioMensual = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite su tipo de contrato, 1 para dependiente y 2 para independiente");
                tipoContrato = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la clase de riesgo: 1, 2, 3, 4 ó 5.");
                claseRiesgo = int.Parse(Console.ReadLine());

                //base de cotizacion

                salario4Deduccion = salarioMensual * 0.4;

                if (salario4Deduccion < SMMLV)
                {
                    salario4Deduccion = SMMLV;
                }






                //deducciones

                switch (tipoContrato)
                {
                    case 1:                         //dependiente

                        pension = 0.04 * salario4Deduccion;
                        eps = 0.04 * salario4Deduccion;
                        arl = 0;

                        break;

                    case 2:                         //Independiente

                        pension = 0.16 * salario4Deduccion;
                        eps = 0.125 * salario4Deduccion;


                        switch (claseRiesgo)  //switch 4 clase de riesgo ;)
                        {
                            case 1:
                                arl = salario4Deduccion * 0.00522;
                                break;

                            case 2:
                                arl = salario4Deduccion * 0.01044;

                                break;

                            case 3:
                                arl = salario4Deduccion * 0.02436;

                                break;

                            case 4:
                                arl = salario4Deduccion * 0.04350;

                                break;

                            case 5:
                                arl = salario4Deduccion * 0.06960;

                                break;
                        }

                        break;
                }

                //procesamiento adicional de dato

                switch (tipoContrato) //para procesar bono
                {
                    case 1:
                        prima = salarioMensual;
                        break;
                    case 2:
                        prima = 0;
                        break;
                }

                deduccionesTotal = eps + pension + arl;

                salarioMensualReal = salarioMensual - deduccionesTotal;

                salarioAnualReal = (salarioMensualReal * 12) + prima;

                //salidas

                Console.WriteLine("Salario mensual: " + salarioMensual);
                Console.WriteLine("Salario mensual REAL: " + salarioMensualReal);
                Console.WriteLine("Salario anual: " + salarioAnualReal);
                Console.WriteLine("Deducciones: " + deduccionesTotal);
                Console.WriteLine("Bonificaciones : " + prima);

                Console.WriteLine("¡Gracias por usar el programa! \n");

            }







        }
    }
}
