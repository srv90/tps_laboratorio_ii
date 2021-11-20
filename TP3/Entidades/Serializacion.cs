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
    public class Serializacion<T> : IAdministradorFiles<T>
        where T: class
    {

        private static string rutaArchivo;

        /// <summary>
        /// Arma la ruta donde sera guardada el archivo
        /// </summary>
        static Serializacion()
        {
            string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo= "Socios.xml";
            rutaArchivo = Path.Combine(applicationData, nombreArchivo);
        }
        /// <summary>
        /// Exporta en xml los datos pasados por parámetro.
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Exportar(T datos)
        {
            bool retorno = false;
            try
            {

              if (rutaArchivo != null)
                {
                    using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        nuevoXml.Serialize(streamWriter, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al querer guardar el archivo: " + rutaArchivo);
            }
            return retorno;
        }
        /// <summary>
        /// Importa los datos en xml que encuentra en la ruta que entra por parámetro.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Importar(string ruta, out T datos)
        {
            bool retorno = false;
            datos = default;

            try
            {
                if (ruta != null)
                {
                    using (StreamReader auxReader = new StreamReader(ruta))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                        datos = (T)nuevoXml.Deserialize(auxReader);
                        retorno = true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return retorno;
        }
    }
}
