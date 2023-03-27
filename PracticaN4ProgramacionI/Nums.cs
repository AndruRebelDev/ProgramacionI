using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN4ProgramacionI
{
    internal class Nums
    {
        float a;
        float b;

        public Nums(float a, float b)
        {
            this.a = a; 
            this.b = b;
        }



        public (float,float,float,float) Operaciones()
        {
            float suma;
            float resta;
            float producto;
            float division;

            suma = a + b;
            resta = a - b;
            producto = a*b;
            division = (float)a/(float)b;


            return(suma,resta, producto, division);
        }

        public int Inverso()
        {
            int invertido;
            int residuo;
            int aux;
            residuo = (int)a % 10;
            invertido = (int)residuo * 100;
            residuo = (int)a / 10;
            aux = residuo;
            residuo = residuo % 10;
            invertido = invertido + (residuo * 10);
            residuo = (int)aux / (int)10;
            invertido = invertido + residuo;

            return invertido;
        }

        public int TresDosDigitos()
        {
            int suma2;
            int numP;
            int numS;

            numP = (int)a / (int)100; 
            numS = (int)b % (int)10;
            suma2 = numP + numS;


            return suma2;
        }

        public int TresDosMultiplicasr()
        {
            int mult;
            int nump2;
            int nump1;
            int num2;

            nump2= (int)b / (int)10;
            nump1 = (int)a / (int)100;
            num2 = (int)a / (int)10;
            num2 = num2 % 10;

            mult = nump2 * num2 * nump1;
            return mult;
        }

        public int CadenaNumS()
        {
            int suma;
            int residuo1;
            int residuo2;

            int n1 = Convert.ToInt32(Console.ReadLine());
            residuo2 = n1 % 10;
            residuo1 = n1 / 10000000;
            suma= residuo1 + residuo2;
            return suma;
        }


        public void MostrarResultados(int result)
        {
            string ret="El resultado es: " + result;
            Console.WriteLine(ret);
        }

       

    }



}
