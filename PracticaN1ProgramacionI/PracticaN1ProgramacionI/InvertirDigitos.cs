using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1ProgramacionI
{
    internal class InvertirDigitos
    {
        int num1, num2;

        public InvertirDigitos(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }


        public void Invertir()
        {
            Console.WriteLine("DigitosOriginales");
            Console.WriteLine(num1 + "-" + num2);
            Console.WriteLine("DigitosInvertidos");
            Console.WriteLine(num2 + "-" + num1);
        
        }



    }
}
