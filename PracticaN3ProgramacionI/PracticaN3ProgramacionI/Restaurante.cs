using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3ProgramacionI
{
    class Restaurante
    {
        float potatoes = 5.45f;
        float hamburger = 22.30f;
        float drinks = 10.25f;
        int cantPo,cantHam,cantDri;
        float totalP, totalH, totalD;

        public Restaurante()
        {
            TomarPedido();
            CalcularEfectivo();
            MostrarPrecios();
        }

        public void TomarPedido()
        {
            Console.WriteLine("BIEVENIDO AL RESTAURANT LOS POLLOS HERMANOS FAMILY");
            Console.WriteLine("¿Que desea ordernar de esta lista?");
            Console.WriteLine("1.Cantidad de porcion de papas fritas");
            cantPo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Cantidad de Hambuergasa");
            cantHam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Cantidad de Gaseosa");
            cantDri = Convert.ToInt32(Console.ReadLine());


        }


        public void CalcularEfectivo()
        {
            float efectivoTotal;

            totalP = cantPo * potatoes;
            Console.WriteLine(cantPo + " Porciones de papas fritas "+": equivale a un costo de: "+totalP+"$");
            totalH = cantHam * hamburger;
            Console.WriteLine(cantHam + " Hamburgesas "+": equivale a un costo de: " + totalH + "$");
            totalD = cantDri * drinks;
            Console.WriteLine(cantDri + " Gaseosas "+": equivale a un costo de: " + totalD + "$");

            efectivoTotal = totalP + totalH + totalD;
            Console.WriteLine("Por lo tanto el monto total a cancelar es: "+efectivoTotal+"$");


        }

        public void MostrarPrecios()
        {
            Console.WriteLine("La porcion de papas fritas cuesta: "+ potatoes +"$");
            Console.WriteLine("La hamburgesa cuesta: " + hamburger + "$");
            Console.WriteLine("El vaso de gaseosa cuesta: " + drinks + "$");
        }

        
    }
}
