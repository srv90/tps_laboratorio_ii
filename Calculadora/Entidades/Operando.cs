using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region atributos
        private double numero;
        #endregion

        #region propiedades
        public String Numero
        {
            set { numero = ValidarOperando(value); }
        }
        #endregion


        #region constructores
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Crea un operando con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero): this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Intenta convertir a numero el parametro de tipo texto
        /// </summary>
        /// <param name="numero"></param>
        public Operando(String numero)
        {
            double.TryParse(numero, out this.numero);
        }


        #endregion



        #region validaciones

        /// <summary>
        /// Valida que el operando este compuesto solo por numeros
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el numero parseado</returns>
        private double ValidarOperando(String strNumero)
        {
            double.TryParse(strNumero, out numero);
            
            return numero;
            

        }

        /// <summary>
        /// Valida que la cadena esta compuesta por 1 y 0
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna true si el numero es binario, sino false</returns>
        private bool EsBinario(String binario)
        {
            foreach (char caracter in binario)
            {
                if(caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region convertores
        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna la conversion, sino un mensaje de error</returns>
        public String BinarioDecimal(String binario)
        {
            if (EsBinario(binario))
            {
                 return Convert.ToInt32(binario,2).ToString();
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna la conversion del numero </returns>
        public String DecimalBinario(double numero)
        {
            if (numero > 0)
            {
                return Convert.ToString((int)numero, 2);
            }
            return "Valor invalido";

        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna la conversion del numero, sino un mensaje de error/returns>
        public String DecimalBinario(String numero)
        {
            if(double.TryParse(numero, out double num))
            {
                return DecimalBinario(num);
            }
            return "Valor invalido";

        }
        #endregion


        #region operaciones
        /// <summary>Hace la suma de ambos operandos
        /// 
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator +(Operando n1, Operando n2)
        {
              return (double)n1 + (double)n2;
        }

        /// <summary>Hace la resta de ambos operandos
        /// 
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return (double)n1 - (double)n2;
        }

        /// <summary>Hace el producto de ambos operandos
        /// 
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return (double)n1 * (double)n2;
        }

        /// <summary>Hace la division de ambos operandos y valida que el segundo operador sea distinto de 0
        /// 
        /// </summary>
        /// <param name="n1">Operando 1</param>
        /// <param name="n2">Operando 2</param>
        /// <returns>Retorna el resultado de la operacion, sino el valor minimo de un double </returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if((double)n2 == 0)
            {
                return double.MinValue;
            }
            return (double)n1 / (double)n2;
        }

        /// <summary>
        /// Convierte al operando en una variable de tipo double
        /// </summary>
        /// <param name="operando"></param>
        public static explicit operator Double(Operando operando)
        {
            return operando.numero;
        }

        #endregion

    }
}
