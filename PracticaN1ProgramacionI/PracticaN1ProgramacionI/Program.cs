﻿using System;

namespace PracticaN1ProgramacionI
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Valores para ingresar en la calse TablaDeMultiplicacion

            //Console.WriteLine("Que tabla deseas obtener:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //-----------------------Ejercicio en clase Promedio 3 numeros-----------------------

            Console.WriteLine("Cuantos numeros deseas ingresar?");
            int b = Convert.ToInt32(Console.ReadLine());

            Promedio2 prom2 = new Promedio2(b);
            prom2.LeerNumeros();
            prom2.MostrarNumeros();
            prom2.CalcularPromedio();

            //-----------------------Ejercicio Tablas-----------------------

            //TablasDeMultiplicacion tablas = new TablasDeMultiplicacion(a);
            //tablas.MostrarTabla();

            //----------------------Ejercicio Promedio 1-----------------

            //Promedio5 prome = new Promedio5();
            //prome.LeerMaterias();
            //prome.LeerPromedios();
            //prome.CalcularPromedio();
            //prome.DefinirCalificacion();
           
            


        }
    }
}
