using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEnAula2
{
    internal class Num
    {
        public int[] n;
        public Num(int nt)
        {
            n = new int[nt];
        }
        public virtual void MostrarNumero()
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("--");
                Console.WriteLine(n[i]);
            }
        }
        public virtual void LeerNumero()
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("INGRESE NUMERO:");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public virtual void RealizarCalculo()
        {



        }

       
    }

    class SumaProducto : Num
    {
        public SumaProducto(int nt) : base(nt)
        {
        }
        public override void RealizarCalculo()
        {
            int suma;
            int resta;

            suma = n[0] + n[1];
            resta = n[0] - n[1];
            Console.WriteLine("LA SUMA ES: " + suma);
            Console.WriteLine("LA RESTA ES: " + resta);
        }
    }


    class SumaProductoPares : Num
    {
        public SumaProductoPares(int nt) : base(nt)
        {
        }
        public override void RealizarCalculo()
        {
            int suma;
            int mult;

            suma = n[0] + n[1];
            mult = n[2] * n[3];
            Console.WriteLine("LA SUMA ES DE LOS DOS PRIMEROS NUMEROS ES: " + suma);
            Console.WriteLine("EL PRODUCTO DE LOS DOS ULTIMOS NUMEROS ES: " + mult);
        }

    }

    class Promedio : Num
    {
        public Promedio(int nt) : base(nt)
        {
        }
        public override void RealizarCalculo()
        {
            float suma = 0;
            float prom;
            for (int i = 0; i < n.Length; i++)
            {
                suma = suma + n[i];
            }
            prom = suma / n.Length;
            Console.WriteLine("LA SUMA ES: " + suma);
            Console.WriteLine("EL PROMEDIO ES: " + prom);
        }

    }

}
