using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3ProgramacionI
{
    class OperacionesBasicas
    {
        float a, b;

        public OperacionesBasicas(float a, float b)
        {
            
            this.a = a;
            this.b = b;

            MostrarOperaciones();
        }

        public void MostrarOperaciones()
        {
            float suma, resta, mult, division, cos, resid;

            suma = a + b;
            Console.WriteLine("SUMA: " + suma);
            resta = a - b;
            Console.WriteLine("RESTA: " + resta);
            mult = a * b;
            Console.WriteLine("MULTIPLICACION: " + mult);
            division = a / b;
            Console.WriteLine("DIVISION: " + division);
            cos = Convert.ToInt32(a / b);
            Console.WriteLine("COOCIENTE DE LA DIVISION: " + cos);
            resid = a % b;
            Console.WriteLine("RESIDUO DE LA DIVISION: " + resid);



        }

    }
}
