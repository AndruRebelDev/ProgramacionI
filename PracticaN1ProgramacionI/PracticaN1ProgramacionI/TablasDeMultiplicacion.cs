using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1ProgramacionI
{
    class TablasDeMultiplicacion
    {
        int tablaNum;
        int count = 1;
        public TablasDeMultiplicacion(int tablaNum)
        {
            this.tablaNum = tablaNum;
        }


        
        public void MostrarTabla()
        {
            //----------------FORMA BASICA----------------
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);
            count += 1;
            Console.WriteLine(tablaNum + "x" + count + "=" + tablaNum * count);

            //-------------FORMA PERSONAL-----------------

            //while(count<=10)
            //{
            //    Console.WriteLine(a + "x" + count + "=" + a * count);
            //    count += 1;
            //}

            //-------------FORMA INTUITIVA-----------------

            //for (int i=1; i<=10;i++)
            //{
            //    Console.WriteLine(a + "x" + i + "=" + a * i);
            //}
        }
    }
}
