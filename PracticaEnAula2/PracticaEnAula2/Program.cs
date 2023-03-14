using System.Threading;
namespace PracticaEnAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Num> lista = new List<Num>();
            
           
            MaquinaDeEscribir maq = new MaquinaDeEscribir();


            int opcion=0;

            while (opcion < 11)
            {
                maq.Maquina(10,"\n\n----------------WELCOME TO ANDRU'S PROGRAM-------------------");
                maq.Maquina(10, "\n\n---------------------------MAIN MENU-------------------");
                maq.Maquina(10, "\n\n1:SUMA Y RESTA");
                maq.Maquina(10, "\n\n2:PERIMETRO DE UN CUADRADO");
                maq.Maquina(10, "\n\n3:SUMA Y PRODUCTO");
                maq.Maquina(10, "\n\n4:SUMA Y PROMEDIO");
                maq.Maquina(10, "\n\n5:COMPRAR ARTICULO");
                maq.Maquina(10, "\n\n6:SUELDO DE UN EMPLEADO DESPUES DE APLICAR DESCUENTOS DE LA EMPRESA");
                maq.Maquina(10, "\n\n7:EQUIVALENCIA DE DIAS EN SEGUNDOS");
                maq.Maquina(10, "\n\n8:DEVOLVER CAMBIO");
                maq.Maquina(10, "\n\n9:SUPERCIFIE DE UN TRIANGULO");
                maq.Maquina(10, "\n\n10:AREA Y VOLUMEN DE UN CILINDRO");
                maq.Maquina(10, "\n\n11:EXIT");
                maq.Maquina(10, "\n\n---------------------------------------------------------------");
                maq.Maquina(10, "\n\n¿Que deseas obtener?");
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