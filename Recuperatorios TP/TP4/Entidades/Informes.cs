using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Informes
    {
        List<Socio> socios;

        #region Constructores

        public Informes(List<Socio> socios)
        {
            this.socios = socios;
        }

        #endregion

        #region Metodos

        public String SociosPorGenero()
        {
            int masculino = 0;
            int femenino = 0;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Socio item in this.socios)
            {
                if (item.Sexo == 'M')
                {
                    masculino++;
                }
                else
                {
                    femenino++;
                }
            }

            stringBuilder.AppendLine("Total de socios: " + (masculino + femenino));
            stringBuilder.AppendLine("Socios masculinos: " + masculino);
            stringBuilder.AppendLine("Socios femeninos: " + femenino);

            return stringBuilder.ToString();

        }

        public string SociosPorPase()
        {
            int gympass = 0;
            int musculacion = 0;
            int libre = 0;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (Socio item in this.socios)
            {
                switch (item.Pase)
                {
                    case Socio.EPase.Gympass:
                        gympass++;
                        break;
                    case Socio.EPase.Musculacion:
                        musculacion++;
                        break;
                    case Socio.EPase.Libre:
                        libre++;
                        break;

                }
            }

            stringBuilder.AppendLine("Socios con pase Gympass: " + gympass.ToString());
            stringBuilder.AppendLine("Socios con pase musculacion: " + musculacion.ToString());
            stringBuilder.AppendLine("Socios con pase libre: " + libre.ToString());

            return stringBuilder.ToString();

        }

        public string SociosPorEstatus()
        {
            int activo = 0;
            int inactivo = 0;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Socio item in this.socios)
            {
                if (item.Status == Socio.EStatus.Activo)
                {
                    activo++;
                }
                else
                {
                    inactivo++;
                }
            }
            stringBuilder.AppendLine("Socios activos: " + activo);
            stringBuilder.AppendLine("Socios inactivos: " + inactivo);

            return stringBuilder.ToString();
        }

        public string SociosPorTipoPago()
        {
            int debito = 0;
            int credito = 0;
            int efectivo = 0;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (Socio item in this.socios)
            {
                switch (item.Pago)
                {
                    case Socio.EPago.Efectivo:
                        efectivo++;
                        break;
                    case Socio.EPago.Credito:
                        credito++;
                        break;
                    case Socio.EPago.Debito:
                        debito++;
                        break;
                }
            }
            stringBuilder.AppendLine("Socios que abonan con debito: " + debito.ToString());
            stringBuilder.AppendLine("Socios que abonan con credito: " + credito.ToString());
            stringBuilder.AppendLine("Socios que abonan en efectivo: " + efectivo.ToString());

            return stringBuilder.ToString();

        }


        public string SociosActivosFormaDePago()
        {
            StringBuilder stringBuilder = new StringBuilder();

            int totalSociosEfectivo = this.socios.Count(element => element.Status == Socio.EStatus.Activo
                                            && element.Pago == Socio.EPago.Efectivo);

            int totalSociosCredito = this.socios.Count(element => element.Status == Socio.EStatus.Activo
                                          && element.Pago == Socio.EPago.Credito);

            int totalSociosDebito = this.socios.Count(element => element.Status == Socio.EStatus.Activo
                                          && element.Pago == Socio.EPago.Debito);

            stringBuilder.AppendLine("Socios activos que abonan en efectivo : " + totalSociosEfectivo);
            stringBuilder.AppendLine("Socios activos que abonan con credito : " + totalSociosCredito);
            stringBuilder.AppendLine("Socios activos que abonan con debito : " + totalSociosDebito);

            return stringBuilder.ToString();

        }


        public string SociosActivosTipoDePase()
        {
            StringBuilder stringBuilder = new StringBuilder();

            int totalSociosLibre = this.socios.Count(element => element.Status == Socio.EStatus.Activo
                                            && element.Pase == Socio.EPase.Libre);

            int totalSociosMusculacion = this.socios.Count(element => element.Status == Socio.EStatus.Activo
                                          && element.Pase == Socio.EPase.Musculacion);

            int totalSociosGympass = this.socios.Count(element => element.Status == Socio.EStatus.Activo
                                          && element.Pase == Socio.EPase.Gympass);

            stringBuilder.AppendLine("Socios activos con pase 'Libre' : " + totalSociosLibre);
            stringBuilder.AppendLine("Socios activos con pase 'Musculacion'  : " + totalSociosMusculacion);
            stringBuilder.AppendLine("Socios activos con pase 'Gympass'  : " + totalSociosGympass);

            return stringBuilder.ToString();
        }

        public string TotalPorTipoDePase()
        {
            StringBuilder stringBuilder = new StringBuilder();

            int totalPaseLibre = this.socios.Count(element => element.Pase == Socio.EPase.Libre);

            int totalPaseMusculacion = this.socios.Count(element => element.Pase == Socio.EPase.Musculacion);

            int totalPaseGympass = this.socios.Count(element =>  element.Pase == Socio.EPase.Gympass);

            stringBuilder.AppendLine("Total por pase 'Libre' : " + totalPaseLibre * Gimnasio.PrecioPaseLibre + " $" );
            stringBuilder.AppendLine("Total por pase 'Musculacion'  : " + totalPaseMusculacion * Gimnasio.PrecioMusculacion + " $");
            stringBuilder.AppendLine("Total por con pase 'Gympass'  : " + totalPaseGympass * Gimnasio.PrecioGymPass + " $");

            return stringBuilder.ToString();
        }

        #endregion
    }
}
