using System;

namespace PracticaN1ProgramacionI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tabla deseas obtener:");
            int a = Convert.ToInt32(Console.ReadLine());

            TablasDeMultiplicacion tablas = new TablasDeMultiplicacion(a);
            tablas.MostrarTabla();


            Promedio5 prome = new Promedio5();
            prome.LeerMaterias();
            prome.LeerPromedios();
            prome.CalcularPromedio();
           
            


        }
    }
}
