using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3ProgramacionI
{
    internal class NumeroDecimal
    {

        double n;
        int cifras;

        public NumeroDecimal()
        {
            Console.WriteLine("Ingresa un numero");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantas cifras deseas ver?");
            cifras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero decimal es: " + Math.Round(n, cifras));
        }
    }
}
