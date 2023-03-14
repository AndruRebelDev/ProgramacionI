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

        public virtual void DibujarFigura()
        {

        }

    }


    class Cuadrado : Figuras
    {

        public override void LeerDatos()
        {
            base.LeerDatos();
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            lados = new double[1];
            for (int i = 0; i < lados.Length; i++)
            {
                maq.Maquina(30, "\n\n INGRESE EL VALOR DE UN LADO DEL CUADRARO: ");
                lados[i] = float.Parse(Console.ReadLine());
            }


        }

        public override void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            baseF = 4 * lados[0];

            maq.Maquina(30, "\n\n LA BASE DEL CUADRADO EQUIVALE A: " + baseF);
        }

        public override void DibujarFigura()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(5, "\n |----------|");
            maq.Maquina(5, "\n |          |");
            maq.Maquina(5, "\n |          |" + "L = " + lados[0] + " cm");
            maq.Maquina(5, "\n |          |");
            maq.Maquina(5, "\n |__________|");
            maq.Maquina(5, "\n      B = " + baseF);
            Console.WriteLine("");
        }
    }

    class Cilindro : Figuras
    {
        public override void LeerDatos()
        {
            base.LeerDatos();
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(30, "\n\n INGRESE EL RADIO DEL CILINDRO: ");
            radio = float.Parse(Console.ReadLine());
            maq.Maquina(30, "\n\n INGRESE LA ALTURA DEL CILINDRO: ");
            haltura = float.Parse(Console.ReadLine());

        }

        public override void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            area = 2 * MathF.PI * radio * (radio + haltura);
            maq.Maquina(30, "\n\n EL AREA DEL CILINDRO ES:" + area + " cm3");
            volumen = MathF.PI * (radio * 2) * haltura;
            maq.Maquina(30, "\n\n EL VOLUMEN DEL CILINDRO ES:" + volumen);
            Console.WriteLine("");
        }

        public override void DibujarFigura()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(5, "\n |--------|");
            maq.Maquina(5, "\n |        |");
            maq.Maquina(5, "\n |--------|" + "V = " + volumen + " cm3");
            maq.Maquina(5, "\n |        |");
            maq.Maquina(5, "\n |        |" + "H = " + haltura);
            maq.Maquina(5, "\n |        |");
            maq.Maquina(5, "\n |________|");
            Console.WriteLine("");
        }
    }

    class Triangulo : Figuras
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
            maq.Maquina(30, "\n\n LA SUPERFICIE DEl TRIANGULO ES:" + superficie + " cm2");
            Console.WriteLine("");
        }

        public override void DibujarFigura()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(5, "\n     *");
            maq.Maquina(5, "\n    ***");
            maq.Maquina(5, "\n   *****");
            maq.Maquina(5, "\n  *******");
            maq.Maquina(5, "\n *********");
            maq.Maquina(5, "\n Superficie = " + superficie +" cm2");
            Console.WriteLine("");

        }

    }

    class TrianguloB : Figuras
    {
        public override void LeerDatos()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            lados = new double[3];
            for (int i = 0; i < lados.Length; i++)
            {
                maq.Maquina(30, "\n\n INGRESE EL VALOR DE UN LADO DEL TRIANGULO: ");
                lados[i] = float.Parse(Console.ReadLine());
            }

        }

        public override void RealizarCalculo()
        {
            perimetro = lados[0] + lados[1] + lados[2];
            perimetro = perimetro / 2;
            area = Math.Sqrt(perimetro * (perimetro - lados[0]) * (perimetro - lados[1]) * (perimetro - lados[2]));
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
           
            maq.Maquina(30, "\n\n EL AREA DEl TRIANGULO ES: " + Math.Round(area,3) + " m2");
         
        }

        public override void DibujarFigura()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(5, "\n                     *");
            maq.Maquina(5, "\n                    ***");
            maq.Maquina(5, "\n L ="+lados[1] +"             *******             " + "L = " +lados[0]);
            maq.Maquina(5, "\n                 ***********");
            maq.Maquina(5, "\n                ***************");
            maq.Maquina(5, "\n                  L = " + lados[2]);
            maq.Maquina(5, "\n      A = " + Math.Round(area, 3) + " m2");
            Console.WriteLine("");



        }
    }
}
