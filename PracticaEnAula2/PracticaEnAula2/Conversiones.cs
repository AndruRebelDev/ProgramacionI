using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEnAula2
{
    internal class Conversiones
    {
        int dias;
        int segundos= 86400;
        int conversioDS;
        public void LeerDatos()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(30, "\n\n INGRESE LA CANTIDAD DE DIAS: ");
            dias = Convert.ToInt32(Console.ReadLine());
        }
        public void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            conversioDS = dias * segundos;
            maq.Maquina(30, "\n\n " + dias +" DIAS EQUIVALEN A: " + conversioDS +" Seg");
            Console.WriteLine("");
        }


    }
}
