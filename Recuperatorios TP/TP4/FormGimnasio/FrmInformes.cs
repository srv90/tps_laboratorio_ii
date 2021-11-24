using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGimnasio
{
    public partial class FrmInformes : Form
    {
        private Gimnasio gimnasio;
        private Informes informes;
        public delegate void ManejarInformes();
        public event ManejarInformes invocarInformes;

        public FrmInformes()
        {
            InitializeComponent();
        }

        public FrmInformes(Gimnasio gimnasio) : this()
        {
            this.gimnasio = gimnasio;
            this.informes = new Informes(this.gimnasio.lista);
        }


        private void FrmInformes_Load(object sender, EventArgs e)
        {
            this.invocarInformes += this.MostrarSociosPorGenero;
            this.invocarInformes += this.MostrarSociosPorPase;
            this.invocarInformes += this.MostrarSociosPorTipoPago;
            this.invocarInformes += this.MostrarSociosPorEstatus;
            this.invocarInformes += this.MostrarSociosActivosFormaDePago;
            this.invocarInformes += this.MostrarSociosActivosTiposDePase;
            this.invocarInformes += this.MostrarTotalPorTipoPase;
            this.invocarInformes.Invoke();

        }


        public void MostrarSociosActivosTiposDePase()
        {
            this.lblSociosActivosPase.Text = informes.SociosActivosTipoDePase();

        }


        public void MostrarSociosActivosFormaDePago()
        {
            this.lblActivosEfectivo.Text = informes.SociosActivosFormaDePago();

        }


        public void MostrarSociosPorPase()
        {
            this.lblPase.Text = informes.SociosPorPase();

        }


        public void MostrarSociosPorEstatus()
        {
            this.lblEstatus.Text = informes.SociosPorEstatus();

        }

        public void MostrarSociosPorGenero()
        {
            this.lblSociosGenero.Text = informes.SociosPorGenero();

        }

        public void MostrarSociosPorTipoPago()
        {
            this.lblSociosPago.Text = informes.SociosPorTipoPago();

        }

        public void MostrarTotalPorTipoPase()
        {
            this.lblTotalPorPase.Text = informes.TotalPorTipoDePase();
        }

        private void FrmInformes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.invocarInformes -= this.MostrarSociosPorGenero;
            this.invocarInformes -= this.MostrarSociosPorPase;
            this.invocarInformes -= this.MostrarSociosPorTipoPago;
            this.invocarInformes -= this.MostrarSociosPorEstatus;
            this.invocarInformes -= this.MostrarSociosActivosFormaDePago;
            this.invocarInformes -= this.MostrarSociosActivosTiposDePase;
            this.invocarInformes -= this.MostrarTotalPorTipoPase;

        }
    }
}
