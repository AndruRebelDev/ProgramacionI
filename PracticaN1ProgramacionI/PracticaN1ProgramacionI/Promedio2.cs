using System;

namespace PracticaN1ProgramacionI
{
    internal class Promedio2
    {
        float[] num ;
        float promedio;

       

        public Promedio2(int tamaño)
        {
            num = new float[tamaño];

        }

        public void LeerNumeros()
        { 

            for(int i=0; i<num.Length;i++)
            {
                Console.WriteLine("Ingrese numero "+ (i+1));
                num[i] = float.Parse(Console.ReadLine());
            }

        
        }


        public void MostrarNumeros()
        {
            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine("Numero:"+ (i+1)+" = "+ num[i]);
            }

        }

        public void CalcularPromedio()
        {
            float suma = 0;
            for (int i = 0; i < num.Length; i++)
            {

                suma = suma + num[i];

            }
            promedio = suma / num.Length;
            Console.WriteLine("El promedio es: "+ promedio);

        }


    }
}
