using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEnAula2
{
    internal class Figuras
    {
        public double area;
        public double baseF;
        public double haltura;
        public double perimetro;
        public double volumen;
        public double radio;
        public double[] lados;
        public double superficie;
       
        public virtual void RealizarCalculo()
        {
           
        }

        public virtual void LeerDatos()
        {
            
        }

    }


    class Cuadrado:Figuras
    {
       
        public override void LeerDatos()
        {
            base.LeerDatos();
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            lados = new double[1];
            for (int i = 0; i < lados.Length; i++)
            {
                maq.Maquina(30, "\n\n INGRESE EL VALOR DE UN LADO DEL CUADRARO: ");
                lados[i] = double.Parse(Console.ReadLine());
            }


        }

        public override void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            baseF = 4 * lados[0];

            maq.Maquina(30, "\n\n LA BASE DEL CUADRADO EQUIVALE A: " + baseF);
        }

    }

    class Cilindro: Figuras
    {
        public override void LeerDatos()
        {
            base.LeerDatos();
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(30, "\n\n INGRESE EL RADIO DEL CILINDRO: ");
            radio = double.Parse(Console.ReadLine());
            maq.Maquina(30, "\n\n INGRESE LA ALTURA DEL CILINDRO: ");
            haltura = double.Parse(Console.ReadLine());

        }

        public override void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            area = 2 * MathF.PI * radio * (radio + haltura);
            maq.Maquina(30, "\n\n EL AREA DEL CILINDRO ES:" + area);
            volumen = MathF.PI * (radio * 2) * haltura;
            maq.Maquina(30, "\n\n EL VOLUMEN DEL CILINDRO ES:" + volumen);
        }
    }

    class Triangulo: Figuras
    {
        public override void LeerDatos()
        {
            base.LeerDatos();
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(30, "\n\n INGRESE LA BASE DEL TRIANGULO: ");
            baseF = double.Parse(Console.ReadLine());
            maq.Maquina(30, "\n\n INGRESE LA ALTURA DEL TRIANGULO: ");
            haltura = double.Parse(Console.ReadLine());

        }

        public override void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            superficie = (baseF * haltura) / 2;
            maq.Maquina(30, "\n\n LA SUPERFICIE DEl TRIANGULO ES:" + superficie);
        }

        public void RealizarCalculo2()
        {
            Console.WriteLine("HOLA AUN NO");
        }

    }
}
