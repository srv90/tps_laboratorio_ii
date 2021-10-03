using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {

        #region Enums

        /// <summary>
        /// Enumerado con las marcas del vehiculo.
        /// </summary>
        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }

        /// <summary>
        /// Enumerado con los tamaños del vehiculo.
        /// </summary>
        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        protected Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }
        #endregion

        #region Attributes

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #endregion

        #region Properties
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion

        #region Methods
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region Operators

        /// <summary>
        /// Castea de forma explicita un objeto tipo vehiculo
        /// y retorna su informacion como un String.
        /// </summary>
        /// <param name="p">Instancia tipo vehiculo a castear</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            if (!(p is null))
            {
                sb.AppendLine($"*** {p.GetType().Name.ToUpper()} ***");
                sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
                sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
                sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
                sb.AppendLine("---------------------");
                sb.AppendFormat("TAMAÑO : {0} ", p.Tamanio);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Retorna true si sus chasis son iguales, sino false.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (!(v1 is null) && !(v2 is null))
            {
                retorno = String.Compare(v1.chasis, v2.chasis) == 0;
            }


            return retorno;

        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Retorna true si sus chasis no son iguales, sino false</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
