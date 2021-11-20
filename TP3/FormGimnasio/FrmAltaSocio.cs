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
    public partial class FrmAltaSocio : Form
    {
        private Socio socio;

        public FrmAltaSocio()
        {
            InitializeComponent();
        }

        public FrmAltaSocio(Socio socio):this()
        {
            this.socio = socio;
            this.AgregarDatosDeUsuario();

        }

        /// <summary>
        /// Se encarga de cargar el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSocio_Load(object sender, EventArgs e)
        {
            this.cmbPase.DataSource = Enum.GetValues(typeof(Socio.EPase));
            this.cmbStatus.DataSource = Enum.GetValues(typeof(Socio.EStatus));
            this.cmbPago.DataSource = Enum.GetValues(typeof(Socio.EPago));
            this.cmbPase.SelectedItem = Socio.EPase.Libre;
            this.cmbPago.SelectedItem = Socio.EPago.Efectivo;
            this.cmbStatus.SelectedItem = Socio.EStatus.Activo;
            this.cmbPase.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            if(this.socio is null){
                this.txtFechaIngreso.Visible = false;
                this.lblFecha.Visible = false;
            }
            else
            {
                this.txtFechaIngreso.Visible = true;
                this.lblFecha.Visible = true;
            }

        }

        /// <summary>
        /// Agrega los datos del usuario a modificar
        /// </summary>
        private void AgregarDatosDeUsuario()
        {
            this.txtNombre.Text = socio.Nombre;
            this.txtApellido.Text = socio.Apellido;
            this.txtDni.Text = socio.Dni.ToString();
            this.cmbPago.SelectedItem = socio.Pago;
            this.cmbPase.SelectedItem = socio.Pase;
            this.cmbStatus.SelectedItem = socio.Status;
            this.btnAceptar.Text = "Modficar";
            this.txtFechaIngreso.Text = socio.FechaIngreso.ToString();
            this.Text = "Modificar usuario";

        }

        #region Metodos
        /// <summary>
        /// Devuelve un socio
        /// </summary>
        /// <returns>Un objeto tipo socio</returns>
        public Socio AgregarSocio() => this.socio;

        /// <summary>
        /// Se encarga de dar de alta un nuevo socio o modficarlo si ya existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtNombre.Text) ||
                String.IsNullOrWhiteSpace(this.txtApellido.Text) ||
                String.IsNullOrWhiteSpace(this.txtDni.Text))
            {
                MessageBox.Show("Debes completar todos los campos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!int.TryParse(txtDni.Text, out _))
                {

                    MessageBox.Show("El dni ingresado es invalido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else

                if(socio is null)
                {
                    socio = new Socio(this.txtNombre.Text,
                                      this.txtApellido.Text,
                                      this.GetGender(),
                                      int.Parse(this.txtDni.Text),
                                      (Socio.EPase)this.cmbPase.SelectedItem,
                                      (Socio.EStatus)this.cmbStatus.SelectedItem,
                                      (Socio.EPago)this.cmbPase.SelectedItem);
                }
                else
                {
                    socio.Apellido = this.txtApellido.Text;
                    socio.Nombre = this.txtNombre.Text;
                    socio.Pago = (Socio.EPago)this.cmbPase.SelectedItem;
                    socio.Pase = (Socio.EPase)this.cmbPase.SelectedItem;
                    socio.Sexo = this.GetGender();
                    socio.Status = (Socio.EStatus)this.cmbStatus.SelectedItem;
                    socio.Dni = int.Parse(this.txtDni.Text);

                }
                this.DialogResult = DialogResult.OK;

            }
        }

        /// <summary>
        /// Se encarga de establecer el sexo del socio
        /// </summary>
        /// <returns>El sexo del socio</returns>
        private char GetGender() => this.rbtnFemenino.Checked ? 'F' : 'M';

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void FrmSocio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                if (MessageBox.Show("Deseas cerrar la ventana?", "Salir",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

    }
}
