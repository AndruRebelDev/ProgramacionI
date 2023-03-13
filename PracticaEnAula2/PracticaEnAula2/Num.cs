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
           n= new int[nt];
           
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

    class Calculo1: Num
    {
     

        public Calculo1(int nt) : base(nt)
        {
           
        }

        public override void RealizarCalculo()
        {
            int suma;
            int resta;

            suma = n[0] + n[1];
            resta = n[0] - n[1];
            Console.WriteLine("LA SUMA ES: " +suma);
            Console.WriteLine("LA RESTA ES: " + resta);
        }

    }


    class Calculo2: Num
    {
        
        
        public Calculo2(int nt): base(nt)
        {
            
        }

        public override void LeerNumero()
        {
            Console.WriteLine("...");
        }

        public override void MostrarNumero()
        {
            Console.WriteLine("...");

        }
       
        

        public override void RealizarCalculo()
        {
            float ladoC;
            float perimetro;

            Console.WriteLine("INGRESA EL VALOR DE UN LADO DE UN CUADRADO: ");
            ladoC = float.Parse(Console.ReadLine());
            perimetro = 4*ladoC;
            Console.WriteLine("EL PERIMETRO ES: " + perimetro);
        }

    }

    class Calculo3 : Num
    {


        public Calculo3(int nt) : base(nt)
        {

        }

        public override void RealizarCalculo()
        {
            int suma;
            int mult;

            suma = n[0] + n[1];
            mult = n[2] * n[3];
            Console.WriteLine("LA SUMA ES: " + suma);
            Console.WriteLine("EL PRODUCTO ES: " + mult);
        }

    }

    class Calculo4 : Num
    {


        public Calculo4(int nt) : base(nt)
        {

        }

        public override void RealizarCalculo()
        {
            float suma=0;
            float prom;
            for(int i = 0; i < n.Length; i++)
            {
                suma = suma+ n[i];
            }
          
            prom = suma/n.Length;
            Console.WriteLine("LA SUMA ES: " + suma);
            Console.WriteLine("EL PROMEDIO ES: " + prom);
        }

    }

    class Calculo5 : Num
    {


        public Calculo5(int nt) : base(nt)
        {

        }
        public override void LeerNumero()
        {
            Console.WriteLine("...");
        }

        public override void MostrarNumero()
        {
            Console.WriteLine("...");

        }
        public override void RealizarCalculo()
        {
            float precioA;
            float disposicion;
            float abono;
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(30, "\n\nLAPTOP LENOVO IDEAPAD 5");
            maq.Maquina(30, "\n\nINGRESE EL PRECIO DEL ARTICULO:");
            precioA = Convert.ToInt32(Console.ReadLine());
            maq.Maquina(30, "\n\nINGRESE LA CANTIDAD DE EFECTIVO QUE TIENE EL CLIENTE:");
            disposicion = Convert.ToInt32(Console.ReadLine());
            abono = precioA - disposicion;
            maq.Maquina(30, "\n\nLA CANTIDAD DE ABONO ES DE:"+ abono);



        }

    }
}
