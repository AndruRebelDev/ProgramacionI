using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEnAula2
{
    internal class ProductoCliente
    {
        public string nombreC;
        public string nombreP;
        public float precioP;
        public float disposicionC;
        public float cambio;
        public float abono;
        public virtual void LeerDatos()
        {
        }
        public virtual void RealizarCalculo()
        {
        }


    }

    class AbonoCliente: ProductoCliente
    {
        public override void LeerDatos()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
          
            maq.Maquina(30, "\n\n RESIDENT EVIL 4 REMAKE");
            maq.Maquina(30, "\n\n INGRESE EL PRECIO DEL PRODUCTO: ");
            precioP= float.Parse(Console.ReadLine());
            maq.Maquina(30, "\n\n INGRESE LA CANTIDAD DE EFECTIVO QUE POSEE EL CLIENTEO: ");
            disposicionC= float.Parse(Console.ReadLine());
        }

        public override void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            if (disposicionC > precioP)
            {
                abono = disposicionC - precioP;
                maq.Maquina(30, "\n\nLA CANTIDAD DE ABONO ES DE:" + abono + "PARA LLEGAR AL TOTAL DE: " + precioP);
            }
            else if (disposicionC < precioP)
            {
                abono = precioP - disposicionC;
                maq.Maquina(30, "\n\nLA CANTIDAD DE ABONO ES DE:" + abono + "PARA LLEGAR AL TOTAL DE: " + precioP + "SUMADO A LA DISPOSICION DEL CLIENTE: " + disposicionC);
            }
            if (disposicionC == precioP)
            {
                maq.Maquina(30, "\n\nLA CANTIDAD DE ABONO ES DE:" + 0 + " LA CANTIDAD QUE TIENE EL CLIENTE ES EXACTA PARA ADQUIRIR EL ARTICULO");
            }
        }
    }

    class CambioCliente: ProductoCliente
    {
        public override void LeerDatos()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            maq.Maquina(30, "\n\n INGRESE EL NOMBRE DEL CLIENTE");
            nombreC = Console.ReadLine();
            maq.Maquina(30, "\n\n INGRESE EL NOMBRE DEL PRODUCTO");
            nombreP = Console.ReadLine();
            maq.Maquina(30, "\n\n INGRESE EL PRECIO DEL PRODUCTO: ");
            precioP = float.Parse(Console.ReadLine());
            maq.Maquina(30, "\n\n INGRESE LA CANTIDAD DE EFECTIVO QUE POSEE EL CLIENTEO: ");
            disposicionC = float.Parse(Console.ReadLine());
        }

        public override void RealizarCalculo()
        {
            MaquinaDeEscribir maq = new MaquinaDeEscribir();
            if (disposicionC > precioP)
            {
                cambio = disposicionC - precioP;
                maq.Maquina(30, "\n\nLA CANTIDAD DE CAMBIO ES DE:" + cambio + "Bs");
            }
            else if (disposicionC < precioP)
            {
                maq.Maquina(30, "\n\nEL CLIENTE NO CUNETA CON LA CANTIDAD NECESARIA PARA ADQUIRIR EL PRODUCTO");
            }
            if (disposicionC == precioP)
            {
                maq.Maquina(30, "\n\nLA CANTIDAD DE CAMBIO ES DE:" + 0 + " LA CANTIDAD QUE TIENE EL CLIENTE ES EXACTA PARA ADQUIRIR EL ARTICULO");
            }
        }
    }

   
}
