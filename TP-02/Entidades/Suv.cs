using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {

        #region Constructor
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color) {}

        #endregion


        #region Properties
        /// <summary>
        /// Suv son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion


        #region Methods

        /// <summary>
        /// Obtiene todos los datos del Suv y los lista en un string.
        /// </summary>
        /// <returns>Los datos del Suv como string.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
