using System;
using Entidades;



namespace MiCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {


            Operando operando1 = new Operando();
            operando1.Numero = "9";


            Operando operando2 = new Operando("4");

            Console.WriteLine(Calculadora.Operar(operando1, operando2, '*'));

            Console.WriteLine(operando1.BinarioDecimal("111"));
            Console.WriteLine(operando1.DecimalBinario(126.774));

     
        }
    }
}
