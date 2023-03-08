﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3ProgramacionI
{
    class InvertirD
    {
        float num;
        float numInverso;
        int cantidadD;

        public InvertirD(float num)
        {
            this.num = num;
            CalcularDigitos();
            DeterminarOp();
        }


        public void InvertirDigitos()
        {

            //---------------Solo con dos digitos-----------
            float residuo;
            residuo = num % 10;


            //Console.WriteLine("ComprobarNum" + num);
            numInverso = residuo * 10;
            //El numero inverso añade un digito multiplicando el residuo *10


            num = (int)num / 10;
             // El numero actualiza su valor con la parte entera de la divison entre 10

            //Console.WriteLine("ComprobarNum" + num);
            residuo = num % 10;
            // Se vuelve a determinar el residuo

            numInverso = (numInverso + num);
            Console.WriteLine("El numero inverso es: " + numInverso);
            //Finalmente se le suma al numeo inverso actual el numero restante despues de la division con la parte entera
           
        }

        public void InvertirDigitosM2()
        {
            //PROCESO INCIAL
            float residuo;
            residuo = num % 10;
            Console.WriteLine("ComprobarNum" + num);
            numInverso = residuo * 10;

            for (int i= 0; i<cantidadD-2;i++)
            {
              // PROCESO REPETITIVO HASTA ANTES DE LLEGAR AL ULTIMO DIGITO
                num = (int)num / 10;
                residuo = num % 10;
                numInverso = (numInverso + residuo) * 10;
                //Console.WriteLine("ComprobarNum" + num);
                
            }

            //PROCESO FINAL SOLO PARA EL ULTIMO DIGITO
            num = (int)num / 10;
            numInverso = (numInverso + num);
            Console.WriteLine("El numero inverso es: " + numInverso);

        }

        public void CalcularDigitos()
        {
            // UN CONTADOR QUE NOS PERMITE ALMACENAR LA CANTIDAD DE DIGITOS DE UN NUMERO DIVIDIENDOLO ENTRE 10
            //HASTA QUE EL VALOR SEA MENOR A 1
            float aux = num;

            while (aux >= 1)
            {
                cantidadD += 1;
                aux = aux / 10;
            }

            Console.WriteLine("El numero tiene: " + cantidadD + " digitos");
        }


        public void DeterminarOp()
        {
            if(cantidadD>2)
            {
                InvertirDigitosM2();
            }
            else
            {
                InvertirDigitos();
            }
        }

    }
}
