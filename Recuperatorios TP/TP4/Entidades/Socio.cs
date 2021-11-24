using System;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Socio
    {
        public enum EPase
        {
            Gympass,
            Musculacion,
            Libre
        }

        public enum EStatus
        {
            Activo,
            Inactivo
        }

        public enum EPago
        {
            Efectivo,
            Credito,
            Debito
        }


        #region Constructores

        public Socio()
        {

        }
        /// <summary>
        /// Inicializa el objeto con la fecha actual
        /// </summary>
        /// <param name="fechaIngreso"></param>
        /// <param name="status"></param>
        public Socio(DateTime fechaIngreso)
        {
            this.FechaIngreso = fechaIngreso;

        }

        /// <summary>
        /// Inicializa el objeto con los datos provistos y establece
        /// el status en true y la fecha en la del momento de creacion
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="dni"></param>
        /// <param name="pase"></param>
        public Socio(string nombre, string apellido, char sexo, int dni, EPase pase, EStatus status, EPago pago)
            : this(DateTime.Now)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Dni = dni;
            this.Pase = pase;
            this.Status = status;
            this.Pago = pago;

        }
        #endregion


        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public int Dni { get; set; }
        public DateTime FechaIngreso { get; set; }
        public EPase Pase { get; set; }
        public EStatus Status { get; set; }
        public EPago Pago { get; set; }

        #endregion

        #region Operadores

        /// <summary>
        /// Valida si dos socios son iguales en base al dni
        /// </summary>
        /// <param name="socio"></param>
        /// <param name="socio1"></param>
        /// <returns>Devuelve true si lo son, sino false</returns>
        public static bool operator ==(Socio socio, Socio socio1)
        {
            return socio is not null && socio1 is not null && socio.Dni == socio1.Dni;
        }
        /// <summary>
        /// </summary>
        /// <param name="socio"></param>
        /// <param name="socio1"></param>
        /// <returns></returns>
        public static bool operator !=(Socio socio, Socio socio1) => !(socio == socio1);

        #endregion

        #region Metodos

        /// <summary>
        /// Rescata la informacion de un socio
        /// </summary>
        /// <returns>Devuelve dicha informacion en formato String</returns>
        public override string ToString()
        {
            return "ID: " + this.Id + " Nombre: " + this.Nombre + " Apellido: " + this.Apellido
                + " Sexo: " + this.Sexo + " DNI: " + this.Dni + " Fecha de ingreso: " + this.FechaIngreso.ToShortDateString()
                + " Estatus: " + this.Status  + " Pase: " + this.Pase + " Pago: " + this.Pago;
        }


        /// <summary>
        /// Valida si el objeto es del mismo tipo de la clase
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Devuelve true si lo es, sino false</returns>
        public override bool Equals(object obj)
        {
            Socio socio = obj as Socio;

            return socio != null && this == socio;
        }

        #endregion

    }
}
