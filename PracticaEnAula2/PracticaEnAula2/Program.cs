using System.Threading;
namespace PracticaEnAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Num> lista = new List<Num>();
            lista.Add(new Calculo1(2));
            lista.Add(new Calculo2(4));
            lista.Add(new Calculo3(4));
            lista.Add(new Calculo4(4));
            lista.Add(new Calculo5(5));
            MaquinaDeEscribir maq = new MaquinaDeEscribir();


            int opcion=0;

            while (opcion < 6)
            {
                maq.Maquina(20,"\n\n----------------WELCOME TO ANDRU'S PROGRAM-------------------");
                maq.Maquina(20, "\n\n---------------------------MAIN MENU-------------------");
                maq.Maquina(50, "\n\n1:SUMA Y RESTA");
                maq.Maquina(50, "\n\n2:PERIMETRO DE UN CUADRADO");
                maq.Maquina(50, "\n\n3:SUMA Y PRODUCTO");
                maq.Maquina(50, "\n\n4:SUMA Y PROMEDIO");
                maq.Maquina(50, "\n\n5:COMPRAR ARTICULO");
                maq.Maquina(50, "\n\n6:EXIT");
                maq.Maquina(30, "\n\n---------------------------------------------------------------");
                maq.Maquina(50, "\n\n¿Que deseas obtener?");
                Console.WriteLine("");
                opcion = Convert.ToInt32(Console.ReadLine());

                lista[opcion - 1].LeerNumero();
                lista[opcion - 1].RealizarCalculo();
              

                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }
        }
    }
}