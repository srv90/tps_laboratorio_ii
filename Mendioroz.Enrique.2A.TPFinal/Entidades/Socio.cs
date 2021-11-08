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

        #region Atributos
        public static int id;
        public int Id;
        #endregion

        #region Constructores

        public Socio()
        {
            Id = Interlocked.Increment(ref id);

        }

        /// <summary>
        /// Inicializa el objeto con los datos provistos y establece
        /// al id como autoincrementable
        /// </summary>
        /// <param name="fechaIngreso"></param>
        /// <param name="status"></param>
        public Socio(DateTime fechaIngreso, bool status):this()
        {
            this.FechaIngreso = fechaIngreso;
            this.Status = status;

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
        public Socio(string nombre, string apellido, char sexo, int dni, EPase pase)
            : this(DateTime.Now, true)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Dni = dni;
            this.Pase = pase;
        }
        #endregion


        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public int Dni { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Status { get; set; }
        public EPase Pase { get; set; }
 
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
                + " Estatus: " + $"{(this.Status ? "ACTIVO" : "INACTIVO")}"   + " Pase: " + this.Pase;
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
