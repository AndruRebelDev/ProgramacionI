using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN4ProgramacionI
{
    internal class Sueldo
    {
        float sueldo;

        public Sueldo(float sueldo)
        {
            this.sueldo = sueldo;
        }

        public float CalcularSueldoTotal()
        {
            float sueldoT;
            float afp = 0.1271f;
            float iva= 0.13f;
            float aporSolid = 0.005f;
            float fondoS = 0.012f;
            float descTotal = sueldo *(afp + iva + aporSolid + fondoS);
            sueldoT = sueldo - descTotal;

            return sueldoT;
        }

        public void MostrarResultados(float result)
        {
            string ret = "El resultado es: " + result;
            Console.WriteLine(ret);
        }
    }
}
