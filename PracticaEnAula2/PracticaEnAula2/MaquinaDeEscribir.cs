using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PracticaEnAula2
{
    internal class MaquinaDeEscribir
    {



        public void Maquina(int velocidad, string texto)
        {
            for(int i = 0; i < texto.Length; i++) 
            {
                Console.Write(texto[i]);
                Thread.Sleep(velocidad);
            }
        }


    }
}
