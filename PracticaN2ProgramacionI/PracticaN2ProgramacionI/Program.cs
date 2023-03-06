namespace PracticaN2ProgramacionI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            
            Console.WriteLine("--------------------------------MENU-------------------------------------");

            Console.WriteLine("Opcion 1: Valores de un cuadrado");
            Console.WriteLine("Opcion 2: Datos de una persona");
            Console.WriteLine("Ingrese opcion");
            int opcion = Convert.ToInt32(Console.ReadLine());
            opcion = Math.Clamp(opcion,1,2);


            if(opcion==1)
            {


                float perimetro = float.Parse(Console.ReadLine());
                ValCuadrado cuadrado = new ValCuadrado(perimetro);
                cuadrado.CalcularPerimetro();
                cuadrado.CalcularArea();


            }
            if (opcion==2)
            {

                Console.WriteLine("Ingresar datos");
                string a, b;
                int c, d, e;

                Console.WriteLine("Ingrese Nombre:");
                a = Console.ReadLine();

                Console.WriteLine("Ingrese Apellido:");
                b = Console.ReadLine();

                Console.WriteLine("Ingrese Edad:");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese mes de nacimiento:");
                d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese dia de nacimiento:");
                e = Convert.ToInt32(Console.ReadLine());


                Persona person = new Persona(a, b, c,d,e);
                person.CalcularAñoDeNacimiento();
                person.MostrarDatos();

            }

           












        }
    }
}