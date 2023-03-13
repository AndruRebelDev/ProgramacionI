using System;

namespace PracticaN3ProgramacionI
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;

            while(opcion<5)
            {
                Console.WriteLine("----------------BIENVENIDO A ANDRU'S PROGRAM-------------------");
                Console.WriteLine("---MENU-------------------");
                Console.WriteLine("1= MOSTRAR UN NUMERO DECIMAL");
                Console.WriteLine("2= INVERTIR LOS DIGITOS DE UN N NUMERO");
                Console.WriteLine("3= MOSTRAR LAS OPERACIONES BASICAS DE ENTRE DOS NUMEROS");
                Console.WriteLine("4= REALIZAR UN PEDIDO EN EL RESTAURANTE LOS POLLOS HERMANOS ");
                Console.WriteLine("5= SALIR ");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("¿Que deseas obtener?");
                opcion = Convert.ToInt32(Console.ReadLine());

                if(opcion==1)
                {
                    NumeroDecimal numD = new NumeroDecimal();
                }

                if (opcion == 2)
                {
                    Console.WriteLine("Ingrese un numero");
                    double a = long.Parse(Console.ReadLine());
                    InvertirD invert = new InvertirD(a);
                }

                if (opcion == 3)
                {
                    Console.WriteLine("Ingrese el primer numero:");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero:");
                    float num2 = float.Parse(Console.ReadLine());
                    OperacionesBasicas opB = new OperacionesBasicas(num1, num2);
                }

                if (opcion == 4)
                {
                    Restaurante rest = new Restaurante();
                }

                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }







            



        }
    }
}
