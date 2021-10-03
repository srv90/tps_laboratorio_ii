using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Enums

        /// <summary>
        /// Enumerador para indicar si el Sedan 
        /// sera de 4 o 5 puertas.
        /// </summary>
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }

        #endregion

        #region Attributes

        private ETipo tipo;

        #endregion

   
        #region Constructors

        /// <summary>
        /// Crea una instancia de Sedan seteando sus atributos.
        /// </summary>
        /// <param name="marca">Marca del Sedan.</param>
        /// <param name="chasis">Chasis del Sedan.</param>
        /// <param name="color">Color del Sedan.</param>
        /// <param name="tipo">Tipo del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Crea una instancia de Sedan, por defecto tipo será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca del Sedan.</param>
        /// <param name="chasis">Chasis del Sedan.</param>
        /// <param name="color">Color del Sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas) { }


        #endregion


        #region Properties

        /// <summary>
        /// Propiedad ReadOnly, Retornara 'Mediano' Para Sedan
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtiene todos los datos del Sedan y los lista en un string.
        /// </summary>
        /// <returns>Los datos del Sedan como string.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TIPO : {this.tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }
}
