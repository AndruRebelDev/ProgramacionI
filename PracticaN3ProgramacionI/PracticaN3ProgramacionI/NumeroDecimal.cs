using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3ProgramacionI
{
    class NumeroDecimal
    {
        double n;

        public NumeroDecimal()
        {
            Console.WriteLine("Ingresa un numero");
            n = double.Parse(Console.ReadLine());
          
            Console.WriteLine("El numero decimal es: "+n);
        }

       

    }
}
