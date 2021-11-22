using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        /// <summary>
        /// /Obtiene la diferencia de tiempo entre dos fechas
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="dateTimeInicio"></param>
        /// <param name="dateTimeFin"></param>
        /// <returns>Retorna la diferencia de tiempo</returns>
        public static TimeSpan ObtenerTiempo(this DateTime dateTime, DateTime dateTimeInicio, DateTime dateTimeFin )
        {
            return dateTimeFin.Subtract(dateTimeInicio);
        }


    }
}
