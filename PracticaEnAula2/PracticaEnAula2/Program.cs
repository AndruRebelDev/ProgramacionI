using System.Threading;
namespace PracticaEnAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //CALCULOS SOLO NUMERICOS
            List<Num> lista = new List<Num>();
            lista.Add(new SumaProducto(2));
            lista.Add(new SumaProductoPares(4));
            lista.Add(new Promedio(4));
          //VALORES DE UNA FIGURA
            List<Figuras> listaF = new List<Figuras>();
            listaF.Add(new Cuadrado());
            listaF.Add(new Triangulo());
            listaF.Add(new Cilindro());
            listaF.Add(new TrianguloB());
            //DESCUENTOS DE SUELDO
            SueldoEmpleado sueldoEmpleado = new SueldoEmpleado();
          //CONVERTIR DIAS A SEGUNDOS
            Conversiones conversiones = new Conversiones();
          //CALCULOS ENTRE PRODUCTO Y CLIENTE
            List<ProductoCliente> listaC = new List<ProductoCliente>();
            listaC.Add(new AbonoCliente());
            listaC.Add(new CambioCliente());

            MaquinaDeEscribir maq = new MaquinaDeEscribir();


            int opcion=0;

            while (opcion < 12)
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
                maq.Maquina(10, "\n\n11:AREA DE UN TRIANGULO");
                maq.Maquina(10, "\n\n12:EXIT");
                maq.Maquina(10, "\n\n---------------------------------------------------------------");
                maq.Maquina(10, "\n\n¿Que deseas obtener?");
                Console.WriteLine("");
                opcion = Convert.ToInt32(Console.ReadLine());

                if(opcion == 1)
                {
                    lista[0].LeerNumero();
                    lista[0].RealizarCalculo();
                }
                if (opcion == 2)
                {
                    listaF[0].LeerDatos();
                    listaF[0].RealizarCalculo();
                    listaF[0].DibujarFigura();
                }
                if (opcion == 3)
                {
                    lista[1].LeerNumero();
                    lista[1].RealizarCalculo();
                }
                if (opcion == 4)
                {
                    lista[2].LeerNumero();
                    lista[2].RealizarCalculo();
                }
                if (opcion == 5)
                {
                    listaC[0].LeerDatos();
                    listaC[0].RealizarCalculo();
                }
                if (opcion == 6)
                {
                    sueldoEmpleado.LeerDatos();
                    sueldoEmpleado.CalcularSueldo();
                }
                if (opcion == 7)
                {
                    conversiones.LeerDatos();
                    conversiones.RealizarCalculo();
                }
                if (opcion == 8)
                {
                    listaC[1].LeerDatos();
                    listaC[1].RealizarCalculo();
                }
                if (opcion == 9)
                {
                    listaF[1].LeerDatos();
                    listaF[1].RealizarCalculo();
                    listaF[1].DibujarFigura();
                }
                if (opcion == 10)
                {
                    listaF[2].LeerDatos();
                    listaF[2].RealizarCalculo();
                    listaF[2].DibujarFigura();
                }
                if (opcion == 11)
                {
                    listaF[3].LeerDatos();
                    listaF[3].RealizarCalculo();
                    listaF[3].DibujarFigura();
                }
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                Console.ReadKey();
            }
        }

        
    }
}