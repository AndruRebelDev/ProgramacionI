namespace PracticaN4ProgramacionI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;

            float sueldo;

            float sum;
            float rest;
            float prod;
            float divi;

            int inver;

            int dd;
            int mm;
            int aa;

            string m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11,m12;

            string cade;

            ////1
            //num1= Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Nums num = new Nums(num1,num2);
            //(sum,rest,prod,divi)=num.Operaciones();
            //Console.WriteLine(sum + " " + rest + " "+ prod + " " + Math.Round(divi,2));
            ////2
            //inver = num.Inverso();
            //Console.WriteLine(inver);
            ////3
            //sueldo= float.Parse(Console.ReadLine());
            //Sueldo sueld = new Sueldo(sueldo);
            //sueld.MostrarResultados(sueld.CalcularSueldoTotal());
            ////4
            //num.MostrarResultados(num.TresDosDigitos());
            //num.MostrarResultados(num.TresDosMultiplicasr());
            ////5
            //num.MostrarResultados(num.CadenaNumS());
            //6
            
           // dd = Convert.ToInt32(Console.ReadLine());
           // Console.Write("/");
           // mm = Convert.ToInt32(Console.ReadLine());
           // Console.Write("/");
           // aa = Convert.ToInt32(Console.ReadLine());
           // FechasMeses fms = new FechasMeses(dd, mm, aa);
           // fms.InvertirFecha();

           // //7
           // m1 = "Enero";
           // m2 = "Febrero";
           // m3 = "Marzo";
           // m4 = "Abril";
           // m5 = "Mayo";
           // m6 = "Junio";
           // m7 = "Julio";
           // m8 = "Agosto";
           // m9 = "Septiembre";
           // m10 ="Octubre";
           // m11 ="Noviembre";
           // m12 ="Diciembre";

           //Console.WriteLine(fms.RecorteMs(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m1 ));

            //8
            cade= Console.ReadLine();
            Cadenas cad = new Cadenas(cade);
            Console.WriteLine(cad.InvertirCadena());

        }
    }
}