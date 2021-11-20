using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Gimnasio
    {
        #region Atributos
        public List<Socio> lista;
        #endregion

        #region Constructores

        /// <summary>
        /// Establece la capacidad por defecto en 20
        /// </summary>
        public Gimnasio()
        {
            this.lista = new List<Socio>();
            this.Capacidad = 15;
        }

        /// <summary>
        /// Establece la capacidad establecida por el usuario siempre y cuando 
        /// respete el limite
        /// </summary>
        /// <param name="capacidad"></param>
        public Gimnasio(int capacidad) : this()
        {
            if (capacidad >= 15 && capacidad <= 40)
            {
                this.Capacidad = capacidad;
            }
        }
        #endregion

        #region Propiedades
        public Int32 LugaresLibres => this.ObtenerCantidadLugaresLibres();
        public int Capacidad { get; set; }
        #endregion


        #region Operators

        /// <summary>
        /// Valida si el socio ya se encuentra en la lista
        /// </summary>
        /// <param name="gimnasio"></param>
        /// <param name="socio"></param>
        /// <returns>Devuelve true si se encuentra, sino false</returns>
        public static bool operator ==(Gimnasio gimnasio, Socio socio)
        {
            bool retorno = false;
            foreach (Socio item in gimnasio.lista)
            {
                if (socio.Equals(item))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida que el socio no este en la lista
        /// </summary>
        /// <param name="gimnasio"></param>
        /// <param name="socio"></param>
        /// <returns></returns>
        public static bool operator !=(Gimnasio gimnasio, Socio socio) => !(gimnasio == socio);

        /// <summary>
        /// Agrega un elemento solo si hay lugar y si el elemento no se encuentra en la lista
        /// </summary>
        /// <param name="gimnasio"></param>
        /// <param name="socio"></param>
        /// <returns>Devuelve true si pudo agregarlo y false caso contrario</returns>
        public static bool operator +(Gimnasio gimnasio, Socio socio)
        {
            bool retorno = false;
            int index;
            if (gimnasio.lista.Count < gimnasio.Capacidad)
            {
                if (!gimnasio.lista.Contains(socio))
                {
                    gimnasio.lista.Add(socio);
                }
                else
                {
                    index = gimnasio.lista.FindIndex(m => m.Id == socio.Id);
                    if (index >= 0)
                        gimnasio.lista[index] = socio;
                }
                retorno = true;
            }
            else
            {
                throw new CapacidadMaximaException("No hay lugares disponibles!!!");
            }
            return retorno;
        }

        /// <summary>
        /// Quita un elemento de la lista
        /// </summary>
        /// <param name="gimnasio"></param>
        /// <param name="socio"></param>
        /// <returns>Devuelve true si pudo hacerlo, sino false</returns>
        public static bool operator -(Gimnasio gimnasio, Socio socio)
        {
            bool retorno = false;
            if (gimnasio.lista.Contains(socio))
            {
                gimnasio.lista.Remove(socio);
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Agrega un elemento 
        /// </summary>
        /// <param name="socio"></param>
        /// <returns>Devuelve true si pudo hacerlo, sino false</returns>
        public bool Agregar(Socio socio)
        {
            return this + socio;
        }

        /// <summary>
        /// Quita un elemento
        /// </summary>
        /// <param name="socio"></param>
        /// <returns>Devuelve true si pudo hacerlo, sino false</returns>
        public bool Remover(Socio socio)
        {
            return this - socio;
        }

        /// <summary>
        /// Obtiene la cantidad de lugares libres
        /// </summary>
        /// <returns>Devuelve la cantidad de lugares libres</returns>
        private int ObtenerCantidadLugaresLibres() => this.Capacidad - this.lista.Count;

        /// <summary>
        /// Calcula el total facturado en base al valor de cada pase
        /// </summary>
        /// <returns>Devuelve el total facturado</returns>
        public int TotalFacturado()
        {
            int total = 0;
            foreach (Socio socio in this.lista)
            {
                if (socio.Pase.Equals(Socio.EPase.Gympass))
                {
                    total += 1000;
                }
                else if (socio.Pase.Equals(Socio.EPase.Libre))
                {
                    total += 2000;
                }
                else
                {
                    total += 500;
                }
            }
            return total;
        }

        /// <summary>
        /// Rescata la informacion del gimnasio
        /// </summary>
        /// <returns>Devuelve dicha informacion como un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Cantidad maxima de socios: " + this.Capacidad);
            sb.AppendLine();
            sb.Append("Cantidad de socios: ");
            sb.AppendLine(this.lista.Count.ToString());
            sb.Append("Recaudacion: ");
            sb.AppendLine(this.TotalFacturado().ToString());

            sb.AppendLine();
            foreach (Socio socio in this.lista)
            {
                if (socio != null)
                {
                    sb.AppendLine(socio.ToString());
                }
            }
            return sb.ToString();

        }


    }
    #endregion

}







