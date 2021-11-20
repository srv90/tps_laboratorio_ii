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
            this.lblSociosGenero.Text = informes.SociosPorGenero();
            this.lblSociosPago.Text = informes.SociosPorTipoPago();
            this.lblEstatus.Text = informes.SociosPorEstatus();
            this.lblPase.Text = informes.SociosPorPase();
            this.lblActivosEfectivo.Text = informes.SociosActivosFormaDePago();
            this.lblSociosActivosPase.Text = informes.SociosActivosTipoDePase();

        }




    }
}
