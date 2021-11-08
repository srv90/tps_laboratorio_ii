using System;
using System.Collections.Generic;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socio socio1 = new Socio("juan", "perez", 'm', 2301234, Socio.EPase.Libre);
            Socio socio2 = new Socio("juan", "perez", 'm', 2301234,  Socio.EPase.Gympass);
            Socio socio3 = new Socio("juan", "perez", 'm', 12312331, Socio.EPase.Gympass);
            Socio socio4 = new Socio("juan", "perez", 'm', 333333, Socio.EPase.Gympass);
            Socio socio5 = new Socio("juan", "perez", 'm', 11111, Socio.EPase.Libre);

            Console.WriteLine(socio1);
            Console.WriteLine(socio2);
            Console.WriteLine(socio3);
            Console.WriteLine(socio4);
            Console.WriteLine(socio5);

            Gimnasio gimnasio = new Gimnasio(10);

            gimnasio.Agregar(socio1);
            gimnasio.Agregar(socio2);
            gimnasio.Agregar(socio3);
            gimnasio.Agregar(socio4);
            gimnasio.Agregar(socio4);
            gimnasio.Agregar(socio4);


            Console.WriteLine(gimnasio.ToString());

        }
    }
}
