using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN4ProgramacionI
{
    internal class FechasMeses
    {
        int dd;
        int mm;
        int aa;

        public FechasMeses(int dd, int mm, int aa)
        {
            this.dd = dd;
            this.mm = mm;
            this.aa = aa;
        }

        public void InvertirFecha()
        {
            Console.WriteLine(dd + "/" + mm + "/" + aa);
            Console.WriteLine(aa + "/" + mm + "/" + dd);
            

        }

        public (string, string, string, string, string, string, string, string, string, string, string, string) LeerMeses()
        {
            string m1 = Console.ReadLine();
            string m2 = Console.ReadLine();
            string m3 = Console.ReadLine();
            string m4 = Console.ReadLine();
            string m5 = Console.ReadLine();
            string m6 = Console.ReadLine();
            string m7 = Console.ReadLine();
            string m8 = Console.ReadLine();
            string m9 = Console.ReadLine();
            string m10 = Console.ReadLine();
            string m11 = Console.ReadLine();
            string m12 = Console.ReadLine();

            return (m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12);

        }

        public string RecorteMs(string m1, string m2, string m3, string m4, string m5, string m6, string m7, string m8, string m9, string m10, string m11, string m12)
        {
            string recorteM;
            int m1L = 1;
            int m2L = 1;
            int m3L = 1;
            int m4L = 1;
            int m5L = 1;
            int m6L = 1;
            int m7L = 1;
            int m8L = 1;
            int m9L = 1;
            int m10L=1;
            int m11L=1;
            int m12L=1;
            Console.WriteLine(m1.Length % 2);
            Console.WriteLine(m5.Length % 2);
            if (m1.Length % 2 != 0)
            {
                m1L = 2;


            }

            if (m2.Length % 2 != 0)
            {
                m2L = 2;

            }

            if (m3.Length % 2 != 0)
            {
                m3L = 2;

            }
            if (m4.Length % 2 != 0)
            {
                m4L = 2;

            }
            if (m5.Length % 2 != 0)
            {

                m5L = 2;


            }
            if (m6.Length % 2 != 0)
            {
                m6L = 2;

            }
            if (m7.Length % 2 != 0)
            {
                m7L = 2;

            }
            if (m8.Length % 2 != 0)
            {
                m8L = 2;

            }
            if (m9.Length % 2 != 0)
            {
                m9L = 2;

            }
            if (m10.Length % 2 != 0)
            {
                m10L = 2;

            }

            if (m11.Length % 2 != 0)
            {
                m11L = 2;

            }
            if (m12.Length % 2 != 0)
            {
                m12L = 2;

            }



            recorteM = m1.Substring(m1.Length/2, m1L) + "-" + m2.Substring(m2.Length / 2, m2L) + "-" + m3.Substring(m3.Length / 2, m3L) + "-" + m4.Substring(m4.Length / 2, m4L) + "-" + m5.Substring(m5.Length / 2, m5L) + "-" + m6.Substring(m6.Length / 2, m6L) + "-" + m7.Substring(m7.Length / 2, m7L) + "-" + m8.Substring(0, 1) + "-" + m9.Substring(m9.Length / 2, m9L) + "-" + m10.Substring(m10.Length / 2, m10L) + "-" + m11.Substring(m11.Length / 2, m11L) + "-" + m12.Substring(m12.Length / 2, m12L );

            return recorteM;
        }

    }
}
