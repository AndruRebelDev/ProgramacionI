﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEnAula2
{
    internal class SueldoEmpleado
    {
        float desAFP = 12.71f/100;
        float desAportes = 0.7f/100;
        float desSegSocial = 5f/100;
        float sueldoBase;
        string nombreEmpleado;
        string cargoEmpleado;
        float desTotal;
        float sueldoFinal;

        public void LeerDatos()
        {
            
            MaquinaDeEscribir maq = new MaquinaDeEscribir();

            maq.Maquina(30, "\n\n INGRESE NOMBRE DEL EMPLEADO: ");
            nombreEmpleado = Console.ReadLine();
            maq.Maquina(30, "\n\n INGRESE EL CARGO DEL EMPLEADO: ");
            cargoEmpleado = Console.ReadLine();
            maq.Maquina(30, "\n\n INGRESE EL SUELDO DEL EMPLEADO: ");
            sueldoBase = float.Parse(Console.ReadLine());
        }
        public void CalcularSueldo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            desTotal = sueldoBase*(desAFP+desAportes+desSegSocial);
            sueldoFinal = sueldoBase - desTotal;
            maq.Maquina(30, "\n\n EL SUELDO DEL EMPLEADO: "+ nombreEmpleado + " DESPUES DE APLICAR LOS DESCUENTOS ES:"+ sueldoFinal+"Bs");
            Console.WriteLine("");
        }




    }
}
