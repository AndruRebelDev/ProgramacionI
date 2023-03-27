using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN4ProgramacionI
{
    internal class Cadenas
    {
        string cadena;

        public Cadenas(string cadena)
        {
            this.cadena = cadena;
        }


        public string InvertirCadena()
        {
            string inverso;
            string mitad1;
            string mitad2;
            if(cadena.Length %2 ==0)
            {
                mitad1 = cadena.Substring(0, cadena.Length / 2);
                mitad2 = cadena.Substring(cadena.Length / 2, cadena.Length / 2);
            }
            else
            {
                mitad1 = cadena.Substring(0, cadena.Length / 2);
                mitad2 = cadena.Substring(cadena.Length / 2, cadena.Length / 2+1);
            }

           
            inverso = mitad2 + mitad1;
            return inverso;
        }


    }
}
