using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN2ProgramacionI
{
    internal class ValCuadrado
    {
        float perimetro;
        float area;
        float lado;

        public ValCuadrado(float perimetro)
        {
            this.perimetro = perimetro;
          
        
        }



        public void CalcularPerimetro()
        {

            lado = perimetro / 4;
            Console.WriteLine("El lado vale: " + lado);
        }

        public void CalcularArea()
        {

            area = lado*lado;
            Console.WriteLine("El area del cuadradoe es: " + area);


        }



    }
}
