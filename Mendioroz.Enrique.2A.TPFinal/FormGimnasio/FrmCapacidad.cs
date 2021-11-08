using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormGimnasio
{
    public partial class FrmCapacidad : Form
    {

        public FrmCapacidad()
        {
            InitializeComponent();
        }

        public int CapacidadGimnasio { get; set; }


        /// <summary>
        /// Se encarga de establecer la capacidad del gimnasio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            

            if (String.IsNullOrWhiteSpace(this.txtCapacidad.Text))
            {
                MessageBox.Show("Debes completar el campo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!int.TryParse(txtCapacidad.Text, out _))
                {
                    MessageBox.Show("La capacidad ingresada es invalida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    CapacidadGimnasio = int.Parse(this.txtCapacidad.Text);
                    if (CapacidadGimnasio < 15 || CapacidadGimnasio > 40)
                    {
                        MessageBox.Show("La capacidad maxima no puede ser menor a 15 ni mayor a 40. " +
                                                      "Se ha establecido por defecto en 15",
                                                      "Atencion!",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}

