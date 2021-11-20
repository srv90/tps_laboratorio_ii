using System;
using System.Collections.Generic;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socio socio1 = new Socio("juan", "perez", 'm', 2301234, Socio.EPase.Libre,Socio.EStatus.Activo, Socio.EPago.Debito);
            Socio socio2 = new Socio("juan", "perez", 'm', 2301234,  Socio.EPase.Gympass,Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio3 = new Socio("juan", "perez", 'm', 12312331, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio4 = new Socio("juan", "perez", 'm', 333333, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio5 = new Socio("juan", "perez", 'm', 11111, Socio.EPase.Libre, Socio.EStatus.Activo, Socio.EPago.Credito);
            Socio socio6 = new Socio("juan", "perez", 'm', 111110, Socio.EPase.Libre, Socio.EStatus.Activo, Socio.EPago.Debito);
            Socio socio7 = new Socio("juan", "perez", 'm', 111112, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio8 = new Socio("juan", "perez", 'm', 111113, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio9 = new Socio("juan", "perez", 'm', 333335, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio10 = new Socio("juan", "perez", 'm', 00111, Socio.EPase.Libre, Socio.EStatus.Activo, Socio.EPago.Credito);
            Socio socio11 = new Socio("juan", "perez", 'm', 9001234, Socio.EPase.Libre, Socio.EStatus.Activo, Socio.EPago.Debito);
            Socio socio12 = new Socio("juan", "perez", 'm', 9101234, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio13 = new Socio("juan", "perez", 'm', 92312331, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio14 = new Socio("juan", "perez", 'm', 9933333, Socio.EPase.Gympass, Socio.EStatus.Inactivo, Socio.EPago.Credito);
            Socio socio15 = new Socio("juan", "perez", 'm', 124311, Socio.EPase.Libre, Socio.EStatus.Activo, Socio.EPago.Credito);
            Socio socio16 = new Socio("juan", "perez", 'm', 12434211, Socio.EPase.Libre, Socio.EStatus.Activo, Socio.EPago.Credito);
            Socio socio17 = new Socio("juan", "perez", 'm', 12004211, Socio.EPase.Libre, Socio.EStatus.Activo, Socio.EPago.Credito);


            Gimnasio gimnasio = new Gimnasio(15);

            gimnasio.Agregar(socio1);
            gimnasio.Agregar(socio2);
            gimnasio.Agregar(socio3);
            gimnasio.Agregar(socio4);

            if (gimnasio.Agregar(socio4))
            {
                Console.WriteLine("El usuario ya se encuentra ingresado!");
            }


            gimnasio.Agregar(socio5);
            gimnasio.Agregar(socio6);
            gimnasio.Agregar(socio7);
            gimnasio.Agregar(socio8);
            gimnasio.Agregar(socio9);
            gimnasio.Agregar(socio10);
            gimnasio.Agregar(socio11);
            gimnasio.Agregar(socio12);
            gimnasio.Agregar(socio13);
            gimnasio.Agregar(socio14);
            gimnasio.Agregar(socio15);
            gimnasio.Agregar(socio16);


 
            try
            {
                gimnasio.Agregar(socio17);

            }
            catch (CapacidadMaximaException e)
            {

                Console.WriteLine(e.Message);
            }



            Console.WriteLine(gimnasio.ToString());

        }
    }
}
