namespace PracticaN2ProgramacionI
{
    internal class Persona
    {
        string nombre, apellido;
        int añoN;
        int mesA = 3;
        int diaA = 6;
        int añoA = 2023;
        int edad;

        int mesN, diaN;

        

        public Persona(string nombre, string apellido, int edad, int mesN,int diaN)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.diaN = diaN;
            this.mesN = mesN;
        }


        public void MostrarDatos()
        {
            Console.WriteLine("LA PERSONA TIENE LOS SIGUIENTES DATOS:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Nacio el año: "+  añoN);

        }

        public void CalcularAñoDeNacimiento()
        {
           

            añoN = 2023 - edad;
        }



    }
}
