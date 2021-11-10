using System;

namespace Entidades
{

    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador sea correcto.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retorna el operador correspondiente o en su defecto el operador '+'.</returns>
        private static char ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '+':
                    return '+';
                case '-':
                    return '-';
                case '*':
                    return '*';
                case '/':
                    return '/';
                default:
                    return '+';
            }

        }
        /// <summary>
        /// Hace las operaciones basicas y retorna el resultado
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de acuerdo a la operacion correspondiente  </returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {

            double resultado = 0;
            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;

            }
            return resultado;

        }
    }
}

