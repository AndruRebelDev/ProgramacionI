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

    class Calculo6 : Num
    {


        public Calculo6(int nt) : base(nt)
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

            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            float descuentoAFP = 12.71f / 100;
            float descuentoAportes = 0.7f / 100;
            float seguros = 5F / 100;
            float sueldoBase;
            string nombreE;
            string cargo;
            float descuentoTotal;
            maq.Maquina(30, "\n\nINGRESE EL SUELDO BASE DEL EMPLEADO: ");
            sueldoBase = float.Parse(Console.ReadLine());
            maq.Maquina(30, "\n\nINGRESE EL NOMBRE DEL EMPLEADO: ");
            nombreE = Console.ReadLine();
            maq.Maquina(30, "\n\nINGRESE EL CARGO QUE OCUPA EL EMPLEADO: ");
            cargo = Console.ReadLine();



            descuentoTotal = sueldoBase-(sueldoBase * (descuentoAFP + descuentoAportes + seguros));
            maq.Maquina(30, "\n\nEL SUELDO DEL EMPLEADO DESPUES DE LOS DESCUENTOS ES: " + descuentoTotal);



        } 
    }

    class Calculo7 : Num
    {


        public Calculo7(int nt) : base(nt)
        {

        }
      

        public override void MostrarNumero()
        {
            Console.WriteLine("...");

        }
        public override void RealizarCalculo()
        {

            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            int segundos = 86400;
            int segundosTotales;
            segundosTotales = n[0] * segundos;
            maq.Maquina(30, "\n\nLOS " + n[0]+ " DIAS " +"EQUIVALEN A : " + segundosTotales + " segundos");



        }
    }

    class Calculo8 : Num
    {


        public Calculo8(int nt) : base(nt)
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

            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            string nombreC;
            string nombreP;
            float cantidadEntregada;
            float precioP;
            float cambio;

            maq.Maquina(30, "\n\nINGRESE EL NOMBRE DEL CLIENTE:");
            nombreC = Console.ReadLine();
            maq.Maquina(30, "\n\nINGRESE EL NOMBRE DEL PRODUCTO");
            nombreP = Console.ReadLine();

            maq.Maquina(30, "\n\nINGRESE EL COSTO DEL PRODUCTO");
            precioP = Convert.ToInt32(Console.ReadLine());

            maq.Maquina(30, "\n\nCUANTO DESEA CANCELAR?");
            cantidadEntregada = Convert.ToInt32(Console.ReadLine());

           

            if(cantidadEntregada>precioP)
            {

                cambio = cantidadEntregada-precioP;
                maq.Maquina(30, "\n\n EL CAMBIO QUE EL CLIENTE DEBE RECIBIR ES: " + cambio + "Bs");

            }
            else if(cantidadEntregada<precioP)
            {
                cambio = precioP - cantidadEntregada;
                maq.Maquina(30, "\n\n EL CAMBIO QUE EL CLIENTE DEBE RECIBIR ES: "+ cambio +"Bs");

            }

            if(cantidadEntregada==precioP)
            {
                maq.Maquina(30, "\n\nNO HAY CAMBIO EL EFECTIVO ES EQUIVALENTE AL COSTO DEL PRODUCTO");
            }



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
            float abono = 0;
            float faltante = 0;
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(30, "\n\nLAPTOP LENOVO IDEAPAD 5");
            maq.Maquina(30, "\n\nINGRESE EL PRECIO DEL ARTICULO:");
            precioA = Convert.ToInt32(Console.ReadLine());
            maq.Maquina(30, "\n\nINGRESE LA CANTIDAD DE EFECTIVO QUE TIENE EL CLIENTE:");
            disposicion = Convert.ToInt32(Console.ReadLine());
            if (disposicion > precioA)
            {
                abono = disposicion - precioA;

                maq.Maquina(30, "\n\nLA CANTIDAD DE ABONO ES DE:" + abono + "PARA LLEGAR AL TOTAL DE: " + precioA);


            }
            else if (disposicion < precioA)
            {
                abono = precioA - disposicion;

                maq.Maquina(30, "\n\nLA CANTIDAD DE ABONO ES DE:" + abono + "PARA LLEGAR AL TOTAL DE: " + precioA + "SUMADO A LA DISPOSICION DEL CLIENTE: " + disposicion);
            }


            if (disposicion == precioA)
            {
                maq.Maquina(30, "\n\nLA CANTIDAD DE ABONO ES DE:" + 0 + " LA CANTIDAD QUE TIENE EL CLIENTE ES EXACTA PARA ADQUIRIR EL ARTICULO");

            }

        }



    }

}
