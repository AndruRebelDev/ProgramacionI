using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1ProgramacionI
{
    class Promedio5
    {
        string[] materias= new string[5];
        float[] nums = new float[5];
        float promedio;
       


        public void LeerMaterias()
        {
            for(int i=0;i<materias.Length;i++)
            {
                Console.WriteLine("Ingrese una materia: ");
                materias[i] = Console.ReadLine();
            }
        }

        public void LeerPromedios()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Ingrese una numero: ");
                nums[i] = float.Parse(Console.ReadLine());
            }
        }

        public void CalcularPromedio()
        {
            float suma=0;
           
            for (int i = 0; i < nums.Length; i++)
            {
                suma = suma + nums[i];
            }

            promedio = suma / 5;
            
            Console.WriteLine("La suma es: "+suma);
            Console.WriteLine("El promedio es: " + promedio);
        }

        public void MostrarDatos()
        {
            for (int i = 0; i < materias.Length; i++)
            {
                Console.WriteLine(materias[i] +": "+ nums[i]);
                
            }
        }

        public void DefinirCalificacion()
        {
            if(promedio>=51.0f)
            {

                Console.WriteLine("El estudiante aprobo");

            }
            else
            {

                Console.WriteLine("El estudiante reprobo");

            }

        }
    }
}
